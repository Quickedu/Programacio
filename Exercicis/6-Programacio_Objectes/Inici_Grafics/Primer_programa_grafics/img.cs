namespace proj1;

using Heirloom;
using Heirloom.Desktop;
using proj1;

public class img {
    private Image imatge;
    private Vector posicio;
    private int velocitat;
    public img(int x, int y)
    {
        imatge = new Image ("img/Imatge1.jpg");
        velocitat = 3;
        posicio = new Vector (x,y);
    }

    public void spawn (GraphicsContext gfx){
        gfx.DrawImage(imatge, posicio);
    }

    public void mou (Rectangle window){
        var newpos = new Rectangle(posicio, imatge.Size);
        if (Input.CheckKey(Key.Right, ButtonState.Down)){
            newpos.X += velocitat;
        }
        if (Input.CheckKey(Key.Left, ButtonState.Down)){
            newpos.X -= velocitat;
        }
        if (Input.CheckKey(Key.Up, ButtonState.Down)){
            newpos.Y -= velocitat;
        }
        if (Input.CheckKey(Key.Down, ButtonState.Down)){
            newpos.Y += velocitat;
        }
        if (window.Contains(newpos)){
            posicio.X = newpos.X;
            posicio.Y = newpos.Y;
        }
    }

}