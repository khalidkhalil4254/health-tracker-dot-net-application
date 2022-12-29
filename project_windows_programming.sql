drop database temp;

create database temp;

use temp;


create table users(
	user_id int auto_increment,
	username varchar(55) unique,
    password varchar(55) NOT NULL,
    fname varchar(55) NOT NULL,
    lname varchar(55) NOT NULL,
    user_role varchar(55) NOT NULL,
    CONSTRAINT PK_Users PRIMARY KEY (user_id)
);

create table user_details(
	details_id int auto_increment,
	user_id int,
	steps double NOT NULL,
    weight double NOT NULL,
    height double NOT NULL,
    age double NOT NULL,
    burned_cal double NOT NULL,
    usrename varchar(55) NOT NULL,
    exercise_date date default(now()),
    primary key(details_id),
	CONSTRAINT FK_UserDetails FOREIGN KEY (user_id)
    REFERENCES users(user_id)
);


/*in code as */
SELECT users.user_id, users.username
FROM users
INNER JOIN user_details ON users.user_id=user_details.user_id;



insert into user_details(steps,weight,height,age,burned_cal,usrename,exercise_date) values(130,80,115,23,5.02,'essam','2022-12-20');


drop table users;
select * from users;


drop table user_details;
select * from user_details;




