
using Aula12Classes;

ClassePersonagens guerreiro = new ClassePersonagens();
guerreiro.nome = "Gwyn-Lorde das Cinzas";
guerreiro.raca = "Humano";
guerreiro.poder = 300;

guerreiro.mostra();

ClassePersonagens mago = new ClassePersonagens();
mago.nome = "Renalla-Rainha da Lua Cheia";
mago.raca = "Elfo";
mago.poder = 150;

mago.mostra();

ClassePersonagens bruxo = mago;
bruxo.nome = "Ranni-The Witch";

bruxo.mostra();


ClassePersonagens anao = new ClassePersonagens();
anao.nome = "Gael-Slave Knight";
anao.raca = "Anão";
anao.poder = 200;

anao.mostra();





Console.ReadKey();
