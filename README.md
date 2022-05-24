# Desafio de Código em C# 
## Desenvolver questões relacionadas ao desafio de código em C# da empresa Verion.

### Questões:

1) Quando um lote de ações de uma companhia é vendido, o ganho de capital (ou, às vezes, a perda) é a diferença entre o preço de venda do lote e o preço originalmente pago por ele. Essa regra é fácil de entender para um único lote, mas se vendermos múltiplos lotes comprados em tempos diferentes temos de identificar os lotes sendo vendidos. Um método usado para identificar que lotes são vendidos é usar uma estrutura que suporte o protocolo FIFO, na qual os lotes vendidos são aqueles que temos há mais tempo (este é o método usado em vários softwares de finanças pessoais). Por exemplo, suponha que compramos 100 lotes a $20 cada no dia 1, 20 lotes a $24 no dia 2, 200 lotes a $36 no dia 3 e vendemos 150 lotes no dia 4 a $30 cada. Aplicando o protocolo FIFO, significa que dos 150 lotes vendidos, 100 foram comprados no dia 1, 20 foram comprados no dia 2 e 30 foram comprados no dia 3. O ganho de capital neste caso seria 100.10+20.6+30.(-6), ou $940.
Escreva um programa que recebe como entrada uma sequência de transações da forma: compre X lotes a $Y cada ou venda X lotes a $Y cada. Assumindo que as transações ocorrem em dias consecutivos e que os valores x e y são inteiros. Dada esta sequência de entradas, a saída deve ser o ganho total (ou perda) de capital para a sequência completa, usando o protocolo FIFO para identificar os lotes. Obs: Utilize uma lista encadeada para armazenar os elementos.

2) Suponha que temos uma sequência S de n elementos, cada um deles pintado de azul ou de vermelho. Suponha que S é representado por um arranjo. Apresente um algoritmo in-place para ordenar S de forma que todos os elementos azuis sejam listados antes de todos os elementos vermelhos.

3) Implemente um método recursivo para determinar se uma sequência S de n objetos inteiros contém um dado inteiro k. O método não pode conter laços.

4) Considere a implementação de listas simplesmente encadeadas utilizando apontadores e com célula cabeça-de-lista head do tipo Nodo. Considere que um dos campos do tipo Nodo é uma chave ch do tipo inteiro (int). Escreva a seguinte função: "boolean EstaNaLista(int ch, Nodo head);". Esta função retorna TRUE se ch estiver na lista e retorna FALSE se ch não estiver na lista. Considere que não há ocorrências de chaves repetidas na lista.


