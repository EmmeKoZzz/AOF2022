namespace Day_5_Supply_Stacks;

// las intefaces se usan para crear clases, son como reglas q las clases deben seguir y asi poder usar estar seguro q una clase (o estructura) q usa una interface
// determinada siempre se va a poder usar en el contexto q quieras ES BASTANTE UTIL
public interface IInstruction
{
   int Move { get; set; }
   int From { get; set; }
   int To { get; set; }
}
