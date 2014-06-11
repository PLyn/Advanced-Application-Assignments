CREATE TABLE IF NOT EXISTS `mydb`.`clienttable` (
  `trn` INT NOT NULL,
  `fname` VARCHAR(45) NULL,
  `lname` VARCHAR(45) NULL,
  `branch` VARCHAR(45) NULL,
  `account_type` VARCHAR(45) NULL,
  `current_balance` DOUBLE NULL,
  PRIMARY KEY (`trn`))
ENGINE = InnoDB