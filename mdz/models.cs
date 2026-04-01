namespace mdz;

public class Stop
{
    public string unique_id { get; set; } = "";
    public string stop_name { get; set; } = "";
}

public class Departure
{
    public string linka { get; set; } = "";
    public string smer { get; set; } = "";
    public string cas_odjezdu { get; set; } = "";
}

public class DepartureView
{
    public int Cislo { get; set; }
    public string CilovaStanice { get; set; } = "";
    public string Odpocet { get; set; } = "";
}