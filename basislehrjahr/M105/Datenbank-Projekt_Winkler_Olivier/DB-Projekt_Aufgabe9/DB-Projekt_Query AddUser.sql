CREATE USER 'User'@'%' IDENTIFIED BY 'f3r13n';
grant select on *.* to 'User'@'%';

CREATE USER 'Administrator'@'localhost' identified by 'f3r13n';
grant all privileges on *.* to 'Administrator'@'localhost';

create user 'Editor'@'%' identified by 'f3r13n';
grant select, delete, update, insert on *.* to 'Editor'@'%';

select * from mysql.user;



