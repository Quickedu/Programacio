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
        img = new Image("C:/Users/eduar/Coses Escriptori/Estudis/DAW Cendrassos/Programació/Backup/Exercicis/6-Programacio_Objectes/Inici_Grafics/1-Princesa_granota/img/Cloud.png");
        velocitat = rnd.Next(1,4);
    }

    public void spawn(GraphicsContext gfx){
        gfx.DrawImage(img,position);
    }

    public void move(Rectangle rect){
    var x = rnd.Next(-7, 8);
    var y = rnd.Next(-7, 8);
    var newpos = new Rectangle(position.X + x, position.Y + y, img.Width, img.Height);
        if (rect.Contains(newpos)){
            position.X += x;
            position.Y += y;
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
        do{
            x = rnd.Next(100,window.Width-100);
            y = rnd.Next(100,window.Height-100);
        } while (mario.tocar(cloud));
        position = (x,y);
    }
}

