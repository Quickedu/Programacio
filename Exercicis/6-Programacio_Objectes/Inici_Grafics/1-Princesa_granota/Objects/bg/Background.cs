using princesa;
namespace princesa;
using Heirloom.Desktop;
using Heirloom;
using System.Security.Cryptography.X509Certificates;

public class BG {
    private Rectangle posicio;
    private Vector position;
    private Image img;

    public BG (Rectangle position , string imatge)
    {
        posicio = position;
        img = new Image(imatge);
    }
    public Rectangle imghitbox (Window window){
        return new Rectangle((0,0),img.Size);
    }
    public void background (GraphicsContext gfx , Rectangle rect){
    gfx.DrawImage(img, posicio);
    }
    public void center(GraphicsContext gfx , Window window){
        var x = (window.Width-img.Width)/2;
        var y = (window.Height-img.Height)/2;
        position=(x,y);
        gfx.DrawImage(img, position);
        return;
    }
}
