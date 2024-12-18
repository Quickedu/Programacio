using System.ComponentModel.Design;
using System.Reflection;
using Heirloom;
using Heirloom.Desktop;
namespace proj1;
using proj1;
class program
{
    public static img imatge;
    public static Window window;
    static void Main (){
        Application.Run( () =>   //el () abans de la => significa un metode anonim. D'aquesta manera no s'ha de definir fora i cridar-lo aqui.
        {
            window = new Window("Primera window siuu", (10,10)) {IsResizable=true};
            window.BeginFullscreen();
            imatge = new img (10,10);
            var loop = GameLoop.Create(window.Graphics, OnUpdate);
            loop.Start();
        });
    }

    static void OnUpdate (GraphicsContext gfx, float dt){
        gfx.Clear(Color.Black);
        imatge.spawn(gfx);
        var fps = gfx.CurrentFPS;
        var Sfps = Math.Round(fps).ToString();
        gfx.DrawText(Sfps,(15,8),Font.Default,30);
        imatge.mou(window.Bounds);
    }
}