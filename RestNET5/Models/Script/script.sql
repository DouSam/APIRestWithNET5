CREATE TABLE IF NOT EXISTS "person" (
  "id" 			bigserial,
  "address" 	varchar(100) NOT NULL,
  "first_name" 	varchar(80)  NOT NULL,
  "gender" 		varchar(6)   NOT NULL,
  "last_name"	varchar(80)  NOT NULL,
  CONSTRAINT pk_person_id PRIMARY KEY (id)
) 