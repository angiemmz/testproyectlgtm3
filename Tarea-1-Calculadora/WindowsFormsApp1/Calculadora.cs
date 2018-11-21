using System;
//usando patron sigleton 
public class Calculadora
{
    //atributos de la clase calculadora
    private decimal operando1;
    private decimal operando2;
    static Calculadora instancia;
    
    //get y set de atributos
    public decimal Operando1
    {
        get => operando1;
        set => operando1 = value;
    }

    public decimal Operando2
    {
        get => operando2;
        set => operando2 = value;
    }

    public static Calculadora Instancia
    {
        get => instancia = getInstancia();
    }

    //cnstructor definido para singleton
    //inicio los operandos en 0
    private Calculadora()
	{
        this.Operando1 = 0;
        this.operando2 = 0;
    }

    //devuelve una solo instacia de la calculadora
    // la crea si es null. Se usa en el get de instancia
    private Calculadora getInstancia()
    {
        if (this.Instancia== null)
        {
            this.Instancia= new Calculadora();
        }
    }

    public decimal suma()
    {
        return (this.Operando1 + this.operando2);
    }

    public decimal resta()
    {
        return (this.Operando1 - this.operando2);
    }

    public decimal division()
    {   //devuelve la division entre los operandos 1 y 2
        //si el 2 no es 0
        if (this.operando2 != 0)
        {
            return (this.Operando1 / this.operando2);
        }
       return 0;  
    }

    public decimal cuadrado()
    {
        return (this.Operando1 * this.Operando1);
    }

    public decimal raiz()
    {   //devuelve la raiz cuadrada del operando 1
        //si no es negativo
        if (this.Operando1 >= 0)
        {
            return Math.Sqrt(this.Operando1);
        }
        return 0;
    }
}
