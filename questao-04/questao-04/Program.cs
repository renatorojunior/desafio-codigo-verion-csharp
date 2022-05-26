using System;

namespace Questao_04
{
	//Estrutura de Nodos.
	public class Node
	{
		public int data;
		public Node next;
		public Node(int n)
		{
			data = n;
			next = null;
		}
	}

	//Classe da Lista Encadeada
	public class LinkedList
	{
		Node head; // Head da lista

		// Insere um novo nodo na frente da lista
		public void push(int new_data)
		{
			// Aloca o novo nodo e inclui os dados
			Node new_node = new Node(new_data);

			// Torna o novo nodo em head
			new_node.next = head;

			// Move o head para apontar para o novo Nodo
			head = new_node;
		}

		// Verifica se a chave ch está presente na lista encadeada
		public bool search(Node head, int ch)
		{
			Node current = head; 
			while (current != null)
			{
				if (current.data == ch)
					return true; // Elemento encontrado
				current = current.next;
			}
			return false; // Elemento não encontrado
		}

		//Código Principal
		public static void Main(String[] args)
		{
			
			//Inicia com a Lista vazia
			LinkedList llist = new LinkedList();

			//Use push() para adicionar itens a lista
			llist.push(1);
			llist.push(2);
			llist.push(3);
			llist.push(4);
			llist.push(5);
			llist.push(6);
			llist.push(7);
			llist.push(8);
			llist.push(9);
			llist.push(10);

			//Verifica se a chave pertence a lista.
			Console.WriteLine("Qual chave você deseja verificar?");
			int ch = int.Parse(Console.ReadLine());

			if (llist.search(llist.head, ch))
				Console.WriteLine("A chave pertence a lista.");
			else
				Console.WriteLine("A chave não pertence a lista.");
		}
	}
}

