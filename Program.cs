using Newtonsoft.Json;

HttpClient repositories = new HttpClient();
repositories.BaseAddress = new Uri("https://api.github.com");
repositories.DefaultRequestHeaders.Add("User-Agent", "request");
repositories.DefaultRequestHeaders.Add("Accept", "application/vnd.github.v3+json");
repositories.DefaultRequestHeaders.Add("Authorization", "token ");

//var username = "JessicaNepomuceno";
var content = await repositories.GetAsync($"user/repos");
var response = await content.Content.ReadAsStringAsync();

var repoGitHub = JsonConvert.DeserializeObject<API.ListaRepositorioGitHub[]>(response);

foreach (var item in repoGitHub)
{
    Console.WriteLine(item.Name);
}
