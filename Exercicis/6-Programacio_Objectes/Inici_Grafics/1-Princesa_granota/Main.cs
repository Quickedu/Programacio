using System.ComponentModel;
using System.Net;
using System.Net.Security;
using System.Xml;
using Heirloom;
using Heirloom.Desktop;
namespace princesa;
class program
{
    private static Window window;
    private static Mario mario;
    private static BG bckground;
    private static BG peach;
    private static BG boo;
    private static Rectangle rect;
    private static List <Cloud> nuvols = new();
    private static bool end = false;
    private static bool lose = false;
    static void Main (){
        Application.Run( () => {
            peach = new BG (rect,"C:/DAW/Programació/Exercicis/6-Programacio_Objectes/Inici_Grafics/1-Princesa_granota/img/Peach.png");
            boo = new BG (rect,"C:/DAW/Programació/Exercicis/6-Programacio_Objectes/Inici_Grafics/1-Princesa_granota/img/KingBoo.png");
            bool ok = true;
            window = new Window ("Salvem la princesa peach dels nuvols!" , MultisampleQuality.High);
            for (int i=0 ; i<10 ; i++){
                nuvols.Add(new Cloud (ok));
                ok = false;
            }
            mario.inici(window);
            var loop = GameLoop.Create(window.Graphics, OnUpdate);
            loop.Start();
        });
    }

    static void OnUpdate(GraphicsContext gfx , float dt){
        if (!end){
            rect = new Rectangle(new Vector(0,0), window.Size);
            bckground.background(gfx,rect);
            mario.spawn(gfx);
            for (int i=0;i<nuvols.Count();i++){
                nuvols[i].spawn(gfx, window, mario);
            }
            foreach (var cloud in nuvols){
                if (mario.tocar(cloud)){
                    if (cloud.peach){
                        end=true;
                    } else {
                        mario.hp--;
                        if (mario.hp==0){
                            end=true;
                            lose=true;
                        }
                        gfx.Clear(Color.White);
                        boo.center(gfx , window);
                        Thread.Sleep(3000);
                        cloud.reposiciona(window, mario);
                    }
                }
            }
        } else {
            if (lose){
                gfx.Clear(Color.White);
                boo.center(gfx , window);
            } else {
                peach.center(gfx,window);
            }
        }
        var fps = gfx.CurrentFPS;
        var Sfps = Math.Round(fps).ToString();
        gfx.DrawText(Sfps,(15,8),Font.Default,30);
    }
}