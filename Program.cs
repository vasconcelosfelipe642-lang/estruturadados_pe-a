using System.Collections.Generic;
using System;

public class pacotesOrdenados
{
    public static void Main(string[] args)
    {
        //CRIAÇÃO DA NOSSA LISTA ORDENADA
        List<int> pacotes = new List<int> {100,110,120,150,160}; 
        
        int pacoteUrgente = 115;
        int i = pacotes.Count - 1; //Explicando: essa váriavel I, é o nosso índice, signfica que o "entregador" está olhando para o final da fila. Como a contagem começa do zero, o último item sempre vai ser o total - 1.
        
        
        //--EXIBIR NO CONSOLE PRIMEIRA LISTA--//
        Console.Write("Lista antiga: ");
        foreach (int p in pacotes) {
            
            Console.Write(p + " ");
        }
        
        //COMO O NOSSO CARRO ESTÁ COM 5 LUGARES E ELES ESTÃO PREENCHIDOS. PRECISAMOS ADICIONAR UM LUGAR A MAIS PARA COLOCAR O NOSSO PACOTE URGENTE.
        pacotes.Add(0);
        
        //INICIANDO O ALGORITMO DE INSERTION SHORT.
        //COMO ESSE ALGORITMO FUNCIONA? COMO O COMPUTADOR NÃO CONSEGUE OLHAR TUDO DE UMA VEZ. ELE PRECISA PEGAR O VALOR DO PACOTE QUE QUEREMOS INSERIR E COMPARAR COM OS PACOTES QUE JÁ ESTÃO DENTRO DO CARRO.
        
        while (pacotes[i] > pacoteUrgente) //ENQUANTO O "pacoteUrgente" for menor que os pacotes da lista
        {
            //EM TERMOS TÉCNICOS. ESTAMOS COPIANDO E COLANDO O ESPAÇO VAZIO NA FRENTE. MAS BASICAMENTE,ESQUEÇA QUE ISSO ESTÁ SENDO COPIADO E PENSE QUE ESTAMOS MOVENDO O PACOTE DE UM BANCO PARA O OUTRO.
            pacotes[i +1] = pacotes[i]; 
            //A LISTA FICA TEMPORARIAMENTE DUPLICADA [150, 160, 160]
            
            //NESSA LINHA ABAIXO, ESTAMOS PEDINDO PARA O "ENTREGADOR" DAR UM PASSO PARA TRÁS E OLHAR O PRÓXIMO PACOTE.
            i = i - 1;
            
            //O LOOP SE ENCERRA ASSIM QUE ENCONTRAR UM VALOR MENOR DO QUE 115.
            //NESSE MOMENTO O LOOP ESTÁ OLHANDO PARA O ÍNDICE DO 110
            
        }
        //NESSE MOMENTO ESTMAOS OLHANDO PARA O PACOTE 110, PORÉM NÃO QUEREMOS COLOCAR O NOSSO PACOTEURGENTE NO LUGAR DO 110.
        
        //PEDIMOS ENTÃO PARA O NOSSO ENTREGADOR, OLHAR PARA O ESPAÇO A FRENTE.
        i = i +1; 
        
        //PEGAMOS O PACOTE URGENTE E COLOCAMOS NO ESPAÇO VAZIO.
        pacotes[i] = pacoteUrgente;
        
        //--EXIBIR NO CONSOLE LISTA COM O PACOTE INSERIDO--//
        Console.Write("\nLista com pacote inserido: ");
        foreach (int p in pacotes) {
            
            Console.Write(p + " ");
        }
    }
}
