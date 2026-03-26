using System.Net.Http;
using System.Net.Http.Json;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        LoadData();
    }

    private async void LoadData()
    {
        var client = new HttpClient();

        var data = await client.GetFromJsonAsync<List<Line>>(
            "https://mhd.adamhojer.cz/lines"
        );

        Stops.DataSource = data;
    }
}