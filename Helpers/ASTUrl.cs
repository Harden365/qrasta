namespace QRasta.Helpers;

public class ASTUrl
{

    private static string[] _ValidURLs = new[]
    {
        "www.roxys.eu",
        "roxys.eu",
        "www.hardenad.net",
        "login.ms365.fr/common/oauth2",
        "login.ms365.fr/oauth2",
        "login.ms365.fr",
        "qroxys31.powerappsportals.com",
        "forms.office.com/e/9amkvAFh3D"
    };
    
    private string _Url { get; set; }

    public ASTUrl(string URL)
    {
        _Url = URL;
    }

    /// <summary>
    /// Determine if URL is valid AST URL
    /// </summary>
    /// <returns></returns>
    public bool IsValid()
    {
        
        Uri uri;

        // Determine if URI is valid absolute URL
        if (!Uri.TryCreate(_Url, UriKind.Absolute, out uri))
            return false;
        
        // Determine if host is in known hosts
        if (!_ValidURLs.Contains(uri.Host.ToLower()))
            return false;
        
        return true;
    }
}
