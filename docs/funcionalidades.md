# Plataforma de cursos online

Essa aplicacao tem como objetivo disponibilizar cursos online, sejam eles gratuitos ou pagos.

Com a plataforma poderemos disponibilizar varias modalidades de acesso aos cursos para os alunos, dentre elas teremos: 

- Planos mensais, semestrais, anuais e customizados.
- Compra de formacoes individuais (varios cursos dentro de uma formacao)
- Compra de curso individual

Os alunos sao livres para escolher a modalidade que se encaixa melhor ao seu perfil.

## **Funcionalidades do sistema:**

### **Catalogo de cursos**

1. Deve ser disponibilizado uma pagina para que os usuarios do sistemas possam visualizar o catalogo de cursos da plataforma, esse catalogo de curso pode ser filtrado por categoria e sua visualizacao pode ser paginada.

2. Para usuarios que possuam curso em andamento deve ser dispobilizada uma visualizacao separada dos cursos em andamento desse usuario.

3. Para usuarios que possuam curso em andamento, ao visualizar o catalogo dos cursos, deve aparecer um indicador de quanto em porcentagem esse curso esta concluido.

4. Para usuarios que possuam cursos finalizados deve ser disponibilizada uma visualizacao separada dos cursos finalizados desse usuario.

5. O curso deve ter um indicador de dificuldade, uma sugestao seria (iniciante, intermediario e avancado).

6. O curso deve contem uma imagem de banner.

7. Ao exibir o catalogo de cursos, se o usuario nao estiver autenticado, nao possuir planos pagos, carreiras pagas e cursos pagos, deve aparecer o valor de compra dos respectivos itens para esse usuario.

8. Quando cursos gratuitos forem exibidos, deve conter a descricao "gratuito".

9. Quando necessario o curso podera contem um valor promocional e um valor nominal.

### **Pagina de detalhes do curso**

1. Na pagina de detalhes do curso, devera ser exibidos os seguintes dados: 

- Nome do curso
- Descricao (permitir insercao de texto rico)
- Dificuldade do curso
- Categoria
- Valor e valor promocional se disponivel
- Banner do curso
- Instrutores do curso
- Carreiras disponiveis com esse curso (Limitado a no maximo 3)
- Pre-requisitos para o curso
- Avaliacoes do curso
- Modulos e aulas do curso com seus respectivos tempos de duracao
- Quantidade de alunos matriculados no curso

2. Se o usuario possuiu o curso, seja ele por plano, compra de carreira ou campra de curso, ele podera acessar as aulas.

3. Se o usuario nao possui o curso, deve estar disponivel uma opcao de compra.

### **Visualizacao das aulas do curso**

Para usuarios que possuam alguma forma de acesso aos cursos, pagos, gratuitos, ou planos. Podera acessar a area de visualizacao de aulas do curso.

1. A visualizacao das aulas devera ser separada por modulos

2. Ao entrar na tela devera estar selecionada a proxima aula depois da ultima aula finalizada.

3. O Player de video deve ser intuitivo e com opcoes como: Qualidade de imagem, difinicoes de volume, tela cheia e velocidade de video.

4. Algumas aulas podem contem links e materiais de apoio, quando disponivel esses itens devem esta visiveis para o usuario.

5. Toda aula possui uma secao de perguntas e respostas, onde alunos e instrutores podem interagir e tirar duvidas da respectiva aula.

6. Ao final de cada modulo, se disponivel, deve ser exibido um questionario para avaliar o conhecimento dos usuarios sobre os assuntos tratados no modulo.

## **Formas de acesso/pagamento**

1. O usuario podera selecionar cursos, carreiras ou planos para realizar o pagamento.

2. Todos os itens acima podem ter valores promocionais.

3. Existe uma ordem de precedencia para acessar os recursos da plataforma. As regra podem ser: 

- Se o usuario comprar uma plano, ele pode acessar todos os cursos e carreiras da plataforma.

- Se o usuario comprar uma carreira, ele pode acessar todos os cursos dessa carreira, os demais cursos do site nao estarao disponiveis para assistir a aula, a nao ser que o curso/carreira seja gratuito.

- Se o usuario comprar um curso, ele podera acessar as aulas desse curso. As carreiras e os demais cursos nao estarao disponiveis, a nao ser que o curso/carreira seja gratuito.

- Todas as compras no sistema para acesso aos cursos tem duracao de um ano.

- A vigencia de novas compras podem ser customizadas caso seja necessario realizar alguma promocao.

- Se o usuario tem um plano ativo, nao sera permitido a compra de carreiras ou cursos a vulso.

- Se o usuario possui uma carreira, nao sera permitido que ele compre cursos a vulso que estejam vinculadoa essa carreira.

- Caso o usuario possui cursos ou carreiras pagas e queira comprar um plano, ele podera adquirir o plano normalmente, porem, a vigencia que sera levada em consideracao para os cursos/planos/carreiras sera a de maior valor.

    Exemplo: 
        
    - Curso pago -> Validade 10/05/2024
    - Novo plano adquirido -> Validade 10/12/2023
    - O usuario podera assistir todos os cursos e carreiras ate a data de 10/12/2023, depois dessa data, apenas o curso adquirido anteriormente com validade ate 10/05/2024 estara disponivel para o usuario.

- A regra acima tambem serve par um usuario que possui um curso e quer adquirir uma carreira.

## **Dados do usuario**

1. O usuario pode ter acesso aos seus pedidos feitos no site.

2. O usuario pode ter acesso aos certificado dos cursos encerrados.

3. O usuario podera adicionar dados de contato como: Endereco e redes sociais.

4. O usuario podera trocar a senha do site em qualquer momento.

5. O usuario podera excluir sua conta a qualquer momento.

6. O usuario nao podera alterar seu email pelo sistema, para realizar esse procedimento devera entrar com contato com os administradores afim de validar o motivo pelo qual essa mudanca devera ser feita.

## **Pagamento**

1. Assim como ja mencionado o usuario podera realizar a compra de cursos, planos e carreiras.

2. O processo de pagamento dece ser realizado pelo sistema, utilizando um provedor de pagamento de terceiros por exemplo com o pagarme.

3. Nao deve-se armazenar os dados do pagamento do usuario como, chave pix ou cartao de credito.

4. A transacao de pagamento pode ser sincrona ou assincrona, se for assincrona deve-se enviar um email para o usuario informado a confirmacao positiva ou negativa do pagamento. Se for sincrona o feedback acontece no momento da transacao.

## **Notificacoes**

1. O usuario deve ser informado via email sempre que adquirir um curso, carreira ou plano.

2. O usuario deve ser avisado por email quando a data de expiracao dos seus produtos estiverem faltando um mes para finalizar.

3. Sempre quando adicionar um novo curso, carreira ou planos o usuario deve ser avisado por email.

## **Autenticacao/Autorizacao**

1. Para realizar o cadastro na plataforma o usuario devera informar o nome, email, cpf e data de nascimento e uma senha forte.

2. Para realizar o login na plataforma o usuario devera informar email e senha.

3. O usuario podera acessar a plataforma realizando o login com redes sociais como: google e github.

4. Caso o usuario esquecer a senha, devera ser enviado um email para recuperacao de senha.


## **Outras funcionalidades**

1. O usuario pode criar uma carreira de estudos personalizada, onde ele podera adicionar cursos ou carreiras que deseja estudar ao longo de sua jornada na plataforma. Esse procedimento so pode ser feito por usuarios autenticados.

