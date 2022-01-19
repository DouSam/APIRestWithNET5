CREATE TABLE "books" (
  "id"			bigint GENERATED ALWAYS AS IDENTITY,
  "author"		varchar(100),
  "launch_date" timestamp NOT NULL,
  "price"		decimal(65,2) NOT NULL,
  "title"		varchar(100),
  CONSTRAINT pk_books_id PRIMARY KEY (id)
  );
