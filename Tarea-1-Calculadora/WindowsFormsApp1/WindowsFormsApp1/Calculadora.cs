using System;

//usando patron sigleton 
public class Calculadora
{
    //atributos de la clase calculadora
    private double operando1;
    private double operando2;
    
    //almacena el pto decimal, para evitar repetirlo
    private double resultado;

    //almacena el operacion binario seleccionado 
    //si tiene ' ', solo se usara el operacion1 (raiz, potencia, %)
    //si tiene el =, se usara el atributo resultado
    private String operacion;
    private String ptoDecimal;

    //instancia Calculadora
    static private Calculadora instancia;
    
    //get y set de atributos
    public double Operando1
    {
        get => operando1;
        set => operando1 = value;
    }

    public double Operando2
    {
        get => operando2;
        set => operando2 = value;
    }

    public String Operacion
    {
        get => operacion;
        set => operacion = value;
    }

    public double Resultado
    {
        get => resultado;
    }

    public String PtoDecimal
    {
        get => ptoDecimal;
        set => ptoDecimal = value;
    }

    //devuelve el operando1 como texto
    public String getStrOperando1()
    {
        return Convert.ToString(this.operando1);
    }

    //asigna valor a operando1 desde un texto
    public void setStrOperando1(String valor)
    {
        this.operando1= Convert.ToDouble(valor);
    }

    //asigna valor a operando2 desde un texto
    public void setStrOperando2(String valor)
    {
        this.operando2 = Convert.ToDouble(valor);
    }

    //devuelve el operando2 como texto
    public String getStrOperando2()
    { 
        return Convert.ToString(this.operando2);
    }

    //devuelve el resultado como texto
    public String getStrResultado()
    {
        return Convert.ToString(this.resultado);
    }

    //constructor definido para singleton
    //inicio los operandos en 0
    private Calculadora()
	{
        this.operando1  = 0.00;
        this.operando2  = 0.00;
        this.resultado  = 0.00;
        this.operacion  = "";
        this.ptoDecimal = "";
    }

    public void reiniciarValores()
    {
        this.operando1  = 0.00;
        this.operando2  = 0.00;
        this.resultado  = 0.00;
        this.operacion  = "";
        this.ptoDecimal = "";
    }

    //devuelve una solo instacia de la calculadora
    // la crea si es null. Se usa en el get de instancia
    static public Calculadora getInstancia()
    {
        if (instancia == null)
        {
            return instancia = new Calculadora();
        }
        return null;  
    }

    /*Operaciones*/
    public void suma()
    {
         this.resultado = Math.Round(this.operando1 + this.operando2);
    }

    public void resta()
    {
        this.resultado = Math.Round(this.operando1 - this.operando2);
    }

    public void division()
    {   //devuelve la division entre los operandos 1 y 2
        //si el 1 no es 0
        if (this.operando1 != 0.00)
        {
            this.resultado = Math.Round(this.operando2 / this.operando1, 2);
        }
        else
        {
            this.resultado = 0.00;
        }
    }

    public void producto()
    {
        this.resultado = Math.Round(this.operando1 * this.operando2, 2);
    }

    public void cuadrado()
    {
        this.resultado = Math.Round(this.operando1 * this.operando1,2);
    }

    public void raiz()
    {   //devuelve la raiz cuadrada del operando 1
        //si no es negativo
        if (this.operando1 >= 0.00)
        {
            this.resultado = Math.Round(Math.Sqrt(this.operando1), 2);
        }
        else
        {
            this.resultado = 0.00;
        }
    }

    public void porcentaje()
    {
        this.resultado = Math.Round(this.operando2 * this.operando1/100, 2);
    }
    /*
    public void cambiarSigno()
    {
        this.operando1 = Math.Round(-1 * this.operando1);
    }
    */
    /*
    public void borrarOperando()
    {
        if (this.operacion == "")
        {
            this.operando1 = 0.00;
        }
        else
        {
            this.operando2 = 0.00;
        }
    }
    */
    /*
    public void borrarDigito()
    {
        String aux = "";
        
        if (this.operacion == "")
        {
            aux = this.getStrOperando1();
            aux = aux.Remove(aux.Length - 1);
            
            if (aux.Length > 0.00)
                this.setStrOperando1(aux);
            else
                this.setStrOperando1("0.00");
        }
        else
        {
            aux = this.getStrOperando2();
            aux = aux.Remove(aux.Length - 1);
            if (aux.Length > 0.00)
                this.setStrOperando2(aux);
            else
                this.setStrOperando2("0.00");
        }

        if (!aux.Contains("."))
        {
            this.ptoDecimal = "";
        }
        
    }

    */

    //metodo de prueba del objeto, devuelbe los operandos como texto
    public override string ToString()
    {
        return "Op1= " + Convert.ToString(this.operando1) + 
                "Op2= " + Convert.ToString(this.operando2) +
                "Operacion "+this.operacion +
                "Resultado= "+this.resultado;
    }
}
