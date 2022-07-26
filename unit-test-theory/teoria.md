# Conceitos de testes unitários

- É um nível de teste de software no qual componentes individuais são testados (métodos);
- O propósito é validar se cada unidade do software executa como o esperado;
- Garantir que problemas serão descobertos cedo;
- Facilitar a manutenção do código;
- Servir como documentação;
- Para ter certeza que o código não tem erro, garantir possíveis entradas do método;
- Geralmente se testa valores chaves que representam esses possíveis entradas;
- Ajudam a melhorar o design do seu código;
- Achou um bug? Não conserte, escreva um teste que o pegue;
- Normalmente o número de linhas de testes são maiores que o código da implementação.

# Padrão AAA

- Arrange: Set things up, Create object instances, Create test data / inputs;
- Act: Execute production code, Call methods;
- Assert: Check result, Check behaviors;

# Mock Objects

Testes unitários devem testar uma classe isoladamente, isto é, sem que o efeito de outras classes com que ela se relaciona, interfiram no teste. Isso é particularmente muito difícil porque a maioria das classes em um sistema real possuem relacionamento com outras classes. Para resolver esse problema, normalmente se usa a metodologia de se criar Mocks.
Objetos Mock são implementações simuladas de uma interface ou classe que define a saída das chamadas dos métodos. Isso permite que você só esteja testando a classe em questão, e que não será afetado por efeitos colaterais. Um teste sempre testará um único método. Se houver chamadas a outros métodos da mesma classe, estes deverão ser mockados.