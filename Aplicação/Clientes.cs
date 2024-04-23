namespace Aplicação{

    class Clientes{
        public string nome {get; set;}
        public string endereco {get; set;}
        public float valor {get; protected set;}
        public float valor_imposto {get; protected set;}
        public float total {get; set;}

        public virtual void Pagar_Imposto(float v){

            valor_imposto = v;
            this.valor_imposto = this.valor * 10 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}