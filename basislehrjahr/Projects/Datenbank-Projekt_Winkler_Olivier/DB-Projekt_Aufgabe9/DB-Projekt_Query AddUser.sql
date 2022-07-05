CREATE USER 'User'@'%' IDENTIFIED BY 'soos123';
grant select on *.* to 'User'@'%';
select * from mysql.user;

drop user 'Administrator'@'%';
CREATE USER 'Administrator'@'localhost' identified by 'soos123';
grant all privileges on *.* to 'Administrator'@'localhost';

create user 'Editor'@'%' identified by 'soos123';
grant select, delete, update, insert on *.* to 'Editor'@'%';