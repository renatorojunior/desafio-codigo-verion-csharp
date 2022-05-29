using System;
using System.Collections;

namespace Questao_01
{
    //Lista Encadeada para armazenar uma entrada na QUEUE.
    class Order
    {
        public int id { get; set; } //ID da Ordem
        public string type { get; set; } //Natureza da Ordem
        public int x { get; set; } //Quantidade de Lotes.
        public int y { get; set; } //Valor do Lote.
        public Order next;
    }

    // Classe que representa a QUEUE.
    class Queue
    {
        public Order FirstPos { get; set; }

        //Adiciona ordens a Queue.
        #region Create
        public void Enqueue(Order newOrder)
        {
            if (FirstPos == null)
            {
                FirstPos = newOrder;
            }
            else
            {
                var lastOrder = GetLastOrder();
                lastOrder.next = newOrder;
            }
        }

        private Order GetLastOrder()
        {
            var tempOrder = FirstPos;
            while (tempOrder.next != null)
            {
                tempOrder = tempOrder.next;
            }
            return tempOrder;
        }
        #endregion

        //Retorna todas as ordens adicionadas a Queue.
        #region Read
        public List<Order> GetOrders()
        {
            var queue = new List<Order>();
            var tempOrder = FirstPos;
            while (tempOrder != null)
            {
                queue.Add(tempOrder);
                tempOrder = tempOrder.next;
            }
            return queue;
        }
        #endregion

        //Atualiza dados das Ordens
        #region Update
        public void UpdateOrder(Order order)
        {
            var tempOrder = FirstPos;
            while (tempOrder != null)
            {
                if (order.id == tempOrder.id)
                {
                    tempOrder.x = order.x;
                    
                    return;
                }
                tempOrder = tempOrder.next;
            }
        }
        #endregion

        //Remove itens da Queue
        #region Delete
        public void Dequeue (int orderId) 
        {
            var tempOrder = FirstPos;
            if (FirstPos.id == orderId)
            {
                FirstPos = FirstPos.next;
            }
            else
            {
                while (tempOrder != null)
                {
                    if (orderId == tempOrder.next.id)
                    {
                        tempOrder.next = tempOrder.next.next;
                        return;
                    }
                    tempOrder = tempOrder.next;
                }
            }
        }
        #endregion
    }

    //Programa Principal.
    class Program
    {
        static void Enqueue(Queue queue)
        {
            int id;

            string type = "Compra";
            Console.WriteLine("Quantos lotes você deseja comprar?");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do lote:");
            int y = int.Parse(Console.ReadLine());

            var order = new Order() { id = 0, type = type, x = x, y = y };

            queue.Enqueue(order);
        }

        public static void PrintAllOrders(Queue queue)
        {
            Console.WriteLine($"Ordens que ainda permanecem Compradas!");
            foreach (var item in queue.GetOrders())
            {
                Console.WriteLine($"ID {item.id} - Tipo {item.type} - Lotes {item.x} - Valor R$ {item.y}");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int option;
            var queue = new Queue();
            
            do
            {
                //Definindo um menu de Opções.
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Comprar");
                Console.WriteLine("2 - Vender");
                Console.WriteLine("3 - Resultado");
                Console.WriteLine("4 - Finalizar");

                //Selecionando uma opção.
                option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    Enqueue(queue);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Você escolheu a opção Vender.");
                }
                else if (option == 3)
                {
                    Console.WriteLine("Você escolheu a opção Resultado.");

                    PrintAllOrders(queue);
                     
                }
                else if (option == 4)
                {
                    Console.WriteLine("Finalizando o Programa!");
                } 
                else if (option != 1 || option != 2 || option != 3 || option != 4)            
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha um opção indicada no Menu.");
                }

            }
            while (option != 4);           
          
        }
    }
    
}
