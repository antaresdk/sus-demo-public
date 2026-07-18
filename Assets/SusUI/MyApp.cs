using Sharq.Core;
using Sharq.Router;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// Public demo entry: SusApp + theme/fonts/icons + SusRouter (open-core only).
/// </summary>
[RequireComponent(typeof(UIDocument))]
public class MyApp : MonoBehaviour
{
    [SerializeField] private SusFontAsset _fonts;

    private void OnEnable()
    {
        Sharq.Core.SusApp.Create(GetComponent<UIDocument>())
            .UseTheme(SusTheme.Dark)
            .UseCustomStyles("branding")
            .UseFonts(_fonts)
            .UseIcons(new ResourcesFolderIconProvider("com.sharq-it.sus.core", "app"))
            .UseRouter(
                new SusRouter(),
                r =>
                {
                    r.Register("/", typeof(HomeScreen));
                },
                initialPath: "/")
            .Run();
    }
}
