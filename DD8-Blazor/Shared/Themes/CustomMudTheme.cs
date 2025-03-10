using MudBlazor;

namespace DD8_Blazor.Shared.Themes
{
    public class CustomMudTheme : MudTheme
    {
        public CustomMudTheme()
        {
            // Configurando a paleta para o tema claro
            PaletteLight = new PaletteLight()
            {
                Primary = "#00F",  // Cor principal
                Secondary = "#FFC107", // Cor secundária
                //Background = "#F9F9F9", // Cor de fundo
                AppbarBackground = "#FFFFFF", // Cor do app bar
                TextPrimary = "#2B2B33", // Cor do texto primário
                TextSecondary = "#2B2B331A" // Cor do texto secundário
            };

            // Configurando a paleta para o tema escuro
            PaletteDark = new PaletteDark()
            {
                Primary = "#1976D2",  // Cor principal
                Secondary = "#FFC107", // Cor secundária
                //Background = "#ffffff", // Cor de fundo para o modo escuro
                //AppbarBackground = "#333333", // Cor do app bar para o modo escuro
                TextPrimary = "#FFFFFF", // Cor do texto primário para o modo escuro
                TextSecondary = "#B0BEC5" // Cor do texto secundário para o modo escuro
            };

            // Configurando o Layout
            LayoutProperties = new LayoutProperties()
            {
                DrawerWidthLeft = "260px", // Largura do drawer à esquerda
                DrawerWidthRight = "300px" // Largura do drawer à direita
            };
        }
    }
}
