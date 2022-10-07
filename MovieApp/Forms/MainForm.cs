using MovieApp.Models;
using System.Text.Json;

namespace MovieApp.Forms;



public partial class MainForm : Form
{
    const string _apiKey = "580270e";
    const string _url = $"http://www.omdbapi.com/?apikey={_apiKey}";


    public MainForm()
    {
        InitializeComponent();
    }

    private async void btn_search_Click(object sender, EventArgs e)
    {
        string search = $"{_url}&t={txt_search.Text}";


        using HttpClient client = new();
        string jsonStr = await client.GetStringAsync(search);


        var movie = JsonSerializer.Deserialize<Movie>(jsonStr);
        pictureBox1.LoadAsync(movie?.Poster);
    }
}
