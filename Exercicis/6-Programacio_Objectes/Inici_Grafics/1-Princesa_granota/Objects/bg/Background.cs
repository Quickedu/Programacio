using princesa;
namespace princesa;
using Heirloom.Desktop;
using Heirloom;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

public class BG {
    private Rectangle posicio;
    private Vector position;
    public Image img {get;set;}

    public BG (Rectangle pos , string imatge)
    {
        posicio = pos;
        img = new Image(imatge);
    }
    public Rectangle imghitbox (Window window){
        return new Rectangle((0,0),img.Size);
    }
    public void background (GraphicsContext gfx, Rectangle rect){
        posicio = rect;
        gfx.DrawImage(img, posicio);
    }
    public void center(GraphicsContext gfx , Window window){
        var x = (window.Width-img.Width)/2;
        var y = (window.Height-img.Height)/2;
        position=(x,y);
        gfx.DrawImage(img, position);
        return;
    }
    public void centerleft (GraphicsContext gfx , Window window , BG peach){
        var x = ((window.Width-img.Width)/2) - (peach.img.Width)/2;
        var y = ((window.Height-img.Height)/2) - 100;
        position = (x,y);
        gfx.DrawImage(img, position);
        return;
    }
    public void centerright (GraphicsContext gfx , Window window , BG peach){
        var x = ((window.Width-img.Width)/2) + (peach.img.Width)/2;
        var y = ((window.Height-img.Height)/2) - 100;
        position=(x,y);
        gfx.DrawImage(img, position);
        return;
    }
    public float width (){
        var x = posicio.X;
        return x;
    }
    public float height (){
        var y = posicio.Y;
        return y;
    }
}
