create table contato (
id int auto_increment,
nome varchar(150),
email varchar(150),
telefone varchar(12),
primary key(id)
);

use db_agenda;

select * from contato;

update contato set nome = 'default', email='default@gmail.com',telefone='34443871' where id='3';

update contato set nome = 'defaultfade', email='default@fade.com',telefone='34456781' where id='2';

insert into contato (nome , email , telefone) values ('Ivsonteste','teste@fade.org.br','318175187');