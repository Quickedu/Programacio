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

    public void spawn(GraphicsContext gfx, Window window, Mario mario){
        posicio(window,mario);
        gfx.DrawImage(img,position);
    }

    public void posicio(Window window, Mario mario){
        var x = 0;
        var y = 0;
        bool ok = false;
        while (!ok){
            x = rnd.Next(10,window.Width-10);
            if (x<(window.Width-mario.img.Width)/2 && x>window.Width+mario.img.Width){
                ok = true;
        }
        while (ok){
            y = rnd.Next(10,window.Height-10);
            if (y<(window.Height-mario.img.Height)/2 && y>window.Height+mario.img.Height){
                ok = false;
            }
        }
        position = (x,y);
        }   
    }

    public void move(Rectangle window){
        var newpos = new Rectangle(position,img.Size);
        newpos.X = rnd.Next(-5,6);
        newpos.Y = rnd.Next(-5,6);
        if (window.Contains(newpos)){
            position.X=newpos.X;
            position.Y=newpos.Y;
        }
    }
    public Vector pos(){
        return position;
    }
    public void reposiciona(Window window, Mario mario){
        var x = 0;
        var y = 0;
        bool ok = false;
        while (!ok){
            x = rnd.Next(10,window.Width-10);
            if (x<(window.Width-mario.img.Width)/2 && x>window.Width+mario.img.Width){
                ok = true;
        }
        while (ok){
            y = rnd.Next(10,window.Height-10);
            if (y<(window.Height-mario.img.Height)/2 && y>window.Height+mario.img.Height){
                ok = false;
            }
        }
        position = (x,y);
        }  
    }
}
