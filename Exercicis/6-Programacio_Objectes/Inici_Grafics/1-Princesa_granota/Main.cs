// ENDED (yay). Still making some small upgrades ^^


using System.ComponentModel;
using System.Dynamic;
using System.Net;
using System.Net.Security;
using System.Runtime.ConstrainedExecution;
using System.Xml;
using Heirloom;
using Heirloom.Desktop;
namespace princesa;
class Program
{
    private static Window window; 
    private static Mario mario;
    private static BG bgmario;
    private static BG bckground;
    private static BG peach;
    private static BG boo;
    private static Rectangle rect;
    private static List <Cloud> nuvols = new();
    private static bool end = false;
    private static bool lose = false;
    private static int status = 0; 
    static void Main (){
        Application.Run( () => {
            window = new Window ("Salvem la princesa peach dels nuvols!");
            window.Maximize();
            mario = new Mario();
            mario.inici(window);
            bgmario = new BG (rect, "C:/DAW/Programació/Exercicis/6-Programacio_Objectes/Inici_Grafics/1-Princesa_granota/img/Mario.png");
            peach = new BG (rect,"C:/DAW/Programació/Exercicis/6-Programacio_Objectes/Inici_Grafics/1-Princesa_granota/img/Peach.png");
            boo = new BG (rect,"C:/DAW/Programació/Exercicis/6-Programacio_Objectes/Inici_Grafics/1-Princesa_granota/img/KingBoo.png");
            bool ok = true;
            for (int i=0 ; i<10 ; i++){
                nuvols.Add(new Cloud (ok));
                ok = false;
            }
            for (int i=0 ; i<nuvols.Count() ; i++){
                nuvols[i].posiciorandom(window,mario,nuvols[i]);
            }
            bckground = new BG(rect,"C:/DAW/Programació/Exercicis/6-Programacio_Objectes/Inici_Grafics/1-Princesa_granota/img/BG.png");
            end = false;
            var loop = GameLoop.Create(window.Graphics, OnUpdate);
            loop.Start();
        });
    }

    static void OnUpdate(GraphicsContext gfx , float dt){
        switch (status){
            case 0:
            game(gfx,dt);
            break;
            case 1:
            fail(gfx,dt);
            break;
            case 2:
            final(gfx,dt);
            break;
        }
    }
    static void game(GraphicsContext gfx, float dt){
        rect = new Rectangle(new Vector (0,0), window.Size);
        bckground.background(gfx,rect);
        mario.mou(rect);
        foreach (var cloud in nuvols){
            cloud.move(rect);
            if (mario.tocar(cloud)){
                if (cloud.peach){
                    status = 2;
                    return;
                } else {
                    mario.hp--;
                    if (mario.hp==0){
                        lose=true;
                        status = 2;
                        return;
                    }
                    status = 1;
                    cloud.reposiciona(window, mario, cloud);
                    return;
                }
            }
            cloud.spawn(gfx);
        }
        mario.spawn(gfx);
        var fps = gfx.CurrentFPS;
        var Sfps = Math.Round(fps).ToString();
        gfx.DrawText(Sfps,(15,8),Font.Default,30);
        gfx.DrawText($"HP: {mario.hp}",(15,38),Font.Default,30);
    }   
    static void fail (GraphicsContext gfx , float dt){
        gfx.Clear(Color.White);
        boo.center(gfx , window);
        var fps = gfx.CurrentFPS;
        var Sfps = Math.Round(fps).ToString();
        gfx.DrawText(Sfps,(15,8),Font.Default,30);
        if (Input.CheckKey(Key.Space , ButtonState.Pressed)){
            status = 0;
        }
    }

    static void final (GraphicsContext gfx , float dt){
            if (lose){
                gfx.Clear(Color.White);
                boo.center(gfx , window);
                return;
            }
            gfx.Clear(Color.Pink);
            peach.centerleft(gfx,window,peach);
            bgmario.centerright(gfx,window,peach);
            gfx.DrawText("HAS TROBAT LA PRINCESA!", (window.Height - (peach.img.Width)/5, (window.Width - peach.img.Width)/2 - 200) , Font.Default , 30 , TextAlign.Center);
    }
}