using princesa;
namespace princesa;
using Heirloom.Desktop;
using Heirloom;

public class BG {
    private Rectangle posicio;
    private Vector position;
    private Image img;

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
}
