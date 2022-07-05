create user 'Administrator1'@'localhost' identified by 'f3r13n';
grant all privileges on *.* to 'Administrator1'@'localhost';

create user 'Editor1'@'%' identified by 'f3r13n';
grant select, update, delete, insert on *.* to 'Editor1'@'%';

create user 'User1'@'%' identified by 'f3r13n';
grant select on filmdb.* to 'User1'@'%';

select user from mysql.user;

