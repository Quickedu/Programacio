using princesa;
namespace princesa;

using System.ComponentModel.Design;
using Heirloom;
using Heirloom.Desktop;

public class Mario{
    public Vector position=(0,0);
    public Image img {get;}
    private int velocitat;
    public int hp {get; set;}

    public Mario()
    {
        img = new Image ("C:/DAW/Programació/Exercicis/6-Programacio_Objectes/Inici_Grafics/1-Princesa_granota/img/Mario.png");
        velocitat = 5;
        hp = 8;
    }

    public void inici(Window window){
        var x = (window.Width-img.Width)/2;
        var y = (window.Height-img.Height)/2;
        position = (x,y);
    }

    public void spawn (GraphicsContext gfx){
        gfx.DrawImage(img,position);
    }

    public void mou (Rectangle window){
        var newpos = new Rectangle(position, img.Size);
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
            position.X = newpos.X;
            position.Y = newpos.Y;
        }
    }
    public bool tocar(Cloud cloud){
        var rectMario = new Rectangle(position, img.Size);
        var rectcloud = new Rectangle(cloud.pos(), cloud.img.Size);
        return (rectMario.Overlaps(rectcloud));
    }
}