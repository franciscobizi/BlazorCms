-- SQLite
CREATE TABLE User
(
    user_id                INTEGER     PRIMARY KEY AUTOINCREMENT,
    user_email             TEXT         NOT NULL,
    user_pass              TEXT         NOT NULL,
    user_source            TEXT,
    user_roles             TEXT,
    user_fname             TEXT,
    user_lname             TEXT,
    user_avatar            TEXT,
    user_registered        TEXT,
    user_logged            TEXT
);

CREATE TABLE Post
(
    post_id                INTEGER     PRIMARY KEY AUTOINCREMENT,
    post_title             TEXT         NOT NULL,
    post_permalink         TEXT         NOT NULL,
    post_content           TEXT,
    post_category          TEXT,
    post_thumbnail         TEXT,
    post_author            INTEGER      NOT NULL,
    post_created           TEXT,
    post_updated           TEXT,
    FOREIGN KEY (post_author) REFERENCES User(user_id)
);

INSERT INTO User(user_id,user_email,user_pass,user_source,user_fname,user_lname,user_avatar,user_registered) 
VALUES
(1,"taylorsoft28@gmail.com","1111","local","Francisco","Bizi","me","2020-12-11"),
(2,"test@gmail.com","1111","local","Test","Tester","me","2020-12-11");

INSERT INTO Post(post_id,post_title,post_permalink,post_content,post_category,post_thumbnail,post_author,post_created,post_updated) 
VALUES
(1,"Coronavirus still between us","Coronavirus still between us","bldlfddfldfff","Heath","feature_image",1,"2020-12-11","2020-12-11"),
(2,"Coronavirus goes from us","Coronavirus goes from us","bldlfddfldfff","Heath","feature_image",1,"2020-12-11","2020-12-11");