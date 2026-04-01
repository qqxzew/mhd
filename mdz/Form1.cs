using System.Net.Http.Json;
using System.Globalization;

namespace mdz;

public partial class Form1 : Form
{
    private readonly HttpClient _client = new HttpClient();

    public Form1()
    {
        InitializeComponent();
        Load += Form1_Load;
    }

    private async void Form1_Load(object? sender, EventArgs e)
    {
        await LoadStopsAsync();
        await LoadLinesAsync();

        Stops.SelectedIndexChanged += ComboBoxes_SelectedIndexChanged;
        Line.SelectedIndexChanged += ComboBoxes_SelectedIndexChanged;
    }

    private async Task LoadStopsAsync()
    {
        try
        {
            var stops = await _client.GetFromJsonAsync<List<Stop>>(
                "https://mhd.adamhojer.cz/stops"
            );

            if (stops == null) return;

            Stops.DataSource = stops;
            Stops.DisplayMember = "stop_name";   // что видно
            Stops.ValueMember = "unique_id";     // id остановки
            Stops.SelectedIndex = -1;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка загрузки остановок: " + ex.Message);
        }
    }

    private async Task LoadLinesAsync()
    {
        try
        {
            var lines = await _client.GetFromJsonAsync<List<string>>(
                "https://mhd.adamhojer.cz/lines"
            );

            if (lines == null) return;

            Line.DataSource = lines;
            Line.SelectedIndex = -1;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка загрузки линий: " + ex.Message);
        }
    }

    private async void ComboBoxes_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (Stops.SelectedIndex == -1 || Line.SelectedIndex == -1)
            return;

        await LoadDeparturesAsync();
    }

    private async Task LoadDeparturesAsync()
    {
        try
        {
            string stopId = Stops.SelectedValue?.ToString() ?? "";
            string line = Line.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(stopId) || string.IsNullOrWhiteSpace(line))
                return;

            string url = $"https://mhd.adamhojer.cz/departures?line={line}&stop={stopId}";

            var departures = await _client.GetFromJsonAsync<List<Departure>>(url);

            if (departures == null)
            {
                dataGridView1.DataSource = null;
                return;
            }

            var tableData = departures
                .Select((d, index) => new DepartureView
                {
                    Cislo = index + 1,
                    CilovaStanice = d.smer,
                    Odpocet = GetCountdown(d.cas_odjezdu)
                })
                .ToList();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = tableData;

            // Переименуем заголовки колонок
            dataGridView1.Columns["Cislo"].HeaderText = "";
            dataGridView1.Columns["CilovaStanice"].HeaderText = "Cílová stanice";
            dataGridView1.Columns["Odpocet"].HeaderText = "Odpočet (mm:ss)";

            // Ширина колонок
            dataGridView1.Columns["Cislo"].Width = 40;
            dataGridView1.Columns["CilovaStanice"].Width = 170;
            dataGridView1.Columns["Odpocet"].Width = 120;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Ошибка загрузки расписания: " + ex.Message);
        }
    }

    private string GetCountdown(string casOdjezdu)
    {
        try
        {
            // Пример: "2026-03-24T13:10:00"
            DateTime departureTime = DateTime.Parse(
                casOdjezdu,
                CultureInfo.InvariantCulture
            );

            TimeSpan diff = departureTime - DateTime.Now;

            if (diff.TotalSeconds <= 0)
                return "00:00";

            return $"{(int)diff.TotalMinutes:00}:{diff.Seconds:00}";
        }
        catch
        {
            return "--:--";
        }
    }

    // Пустые методы, чтобы не было ошибок, если они остались в Designer
    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }
}