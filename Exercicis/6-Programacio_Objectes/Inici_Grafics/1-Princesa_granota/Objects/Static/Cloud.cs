namespace princesa;
using System.Security.Cryptography.X509Certificates;
using Heirloom;
using Heirloom.Desktop;
using princesa;

public class Cloud {
    public Vector position;
    public Image img {get;}
    public bool peach {get;}
    private int velocitat;
    private Random rnd = new();

    public Cloud(bool ok)
    {
        peach=ok;
        img = new Image("C:/DAW/Programació/Exercicis/6-Programacio_Objectes/Inici_Grafics/1-Princesa_granota/img/Cloud.png");
        velocitat = rnd.Next(1,4);
    }

    public void spawn(GraphicsContext gfx){
        gfx.DrawImage(img,position);
    }

    public void move(Rectangle rect){
        var newpos = new Rectangle(position,img.Size);
        newpos.X = rnd.Next(-3,3);
        newpos.Y = rnd.Next(-3,3);
        if (rect.Contains(newpos)){
            position.X+=(newpos.X);
            position.Y+=(newpos.Y);
        }
    }
    public Vector pos(){
        return position;
    }
    public void reposiciona(Window window, Mario mario, Cloud cloud){
        var x = 0;
        var y = 0;
        x = rnd.Next(100,window.Width-100);
        y = rnd.Next(100,window.Height-100);
        position = (x,y);
    }
    public void posiciorandom (Window window, Mario mario, Cloud cloud){
        var x = 0;
        var y = 0;
        x = rnd.Next(100,window.Width-100);
        y = rnd.Next(100,window.Height-100);
        position = (x,y);
    }
}

