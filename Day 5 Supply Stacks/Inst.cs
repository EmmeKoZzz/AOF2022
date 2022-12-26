namespace Day_5_Supply_Stacks;

// Definir un TYPO es una buena practica q en TypeScript se usa bastante aunque alla son Interface y Type , aqui no existe eso
// aqui en C# es clases o estructuras la diferencia es q las clases se tratan por referencia y la estructira es por valor como los tipos imples (int o string)
// esto es lo mas cerca q tiene esto de typescript T_T

// le pongo la interface para probar no para otra cosa xD pero se usa asi
// por ejemplo si una clase esta implementado con la interface lista, entonces esa clase tiene un Count y un index y cosas asi y puede ser una clase cualquiera
// lo q implementada en esa interface
// se usa para cuando definas un metodo no tengas q hacer un metodo para especificar en el parametro a cada clase q sea una lista
// simplemente si le dices q la clase tenga q ser una lista y ya
// muy util, la verdad xD

public struct Inst : IInstruction
{
   public int Move { get; set; }
   public int From { get; set; }
   public int To { get; set; }
}
