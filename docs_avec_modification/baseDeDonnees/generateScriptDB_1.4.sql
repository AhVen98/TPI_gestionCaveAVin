-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema wineManager
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema wineManager
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `wineManager` DEFAULT CHARACTER SET utf8 ;
USE `wineManager` ;

-- -----------------------------------------------------
-- Table `wineManager`.`colors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `wineManager`.`colors` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `wineColor` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  UNIQUE INDEX `wineColor_UNIQUE` (`wineColor` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `wineManager`.`countries`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `wineManager`.`countries` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `countryName` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  UNIQUE INDEX `countryName_UNIQUE` (`countryName` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `wineManager`.`manufacturers`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `wineManager`.`manufacturers` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `country_id` INT NOT NULL,
  `manufacturersName` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  UNIQUE INDEX `manufacturersName_UNIQUE` (`manufacturersName` ASC),
  INDEX `fk_manufacturers_countries_idx` (`country_id` ASC),
  CONSTRAINT `fk_manufacturers_countries`
    FOREIGN KEY (`country_id`)
    REFERENCES `wineManager`.`countries` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `wineManager`.`storageboxes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `wineManager`.`storageboxes` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `location` VARCHAR(100) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `wineManager`.`wines`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `wineManager`.`wines` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `color_id` INT NOT NULL,
  `manufacturer_id` INT NOT NULL,
  `storagebox_id` INT NOT NULL,
  `bottleNumber` INT NOT NULL,
  `productionYear` INT NOT NULL,
  `volume` DOUBLE NOT NULL,
  `wineName` VARCHAR(45) NOT NULL,
  `description` VARCHAR(200) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  UNIQUE INDEX `uniqueWineLot` (`wineName` ASC, `productionYear` ASC, `volume` ASC),
  INDEX `fk_wines_colors1_idx` (`color_id` ASC),
  INDEX `fk_wines_manufacturers1_idx` (`manufacturer_id` ASC),
  INDEX `fk_wines_storageboxes1_idx` (`storagebox_id` ASC),
  CONSTRAINT `fk_wines_colors1`
    FOREIGN KEY (`color_id`)
    REFERENCES `wineManager`.`colors` (`id`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_wines_manufacturers1`
    FOREIGN KEY (`manufacturer_id`)
    REFERENCES `wineManager`.`manufacturers` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `fk_wines_storageboxes1`
    FOREIGN KEY (`storagebox_id`)
    REFERENCES `wineManager`.`storageboxes` (`id`)
    ON DELETE NO ACTION
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `wineManager`.`alerts`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `wineManager`.`alerts` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `alertName` VARCHAR(45) NOT NULL,
  `alertText` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `wineManager`.`grapeVarieties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `wineManager`.`grapeVarieties` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `varietyName` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  UNIQUE INDEX `varietyName_UNIQUE` (`varietyName` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `wineManager`.`logs`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `wineManager`.`logs` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `wine_id` INT NOT NULL,
  `actionName` VARCHAR(45) NOT NULL,
  `detail` VARCHAR(200) NOT NULL,
  `time` DATE NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  INDEX `fk_logs_wines1_idx` (`wine_id` ASC),
  CONSTRAINT `fk_logs_wines1`
    FOREIGN KEY (`wine_id`)
    REFERENCES `wineManager`.`wines` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `wineManager`.`wines_has_grapeVarieties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `wineManager`.`wines_has_grapeVarieties` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `grapeVariety_id` INT NOT NULL,
  `wine_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_wines_has_grapeVarieties_grapeVarieties1_idx` (`grapeVariety_id` ASC),
  INDEX `fk_wines_has_grapeVarieties_wines1_idx` (`wine_id` ASC),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  CONSTRAINT `fk_wines_has_grapeVarieties_wines1`
    FOREIGN KEY (`wine_id`)
    REFERENCES `wineManager`.`wines` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_wines_has_grapeVarieties_grapeVarieties1`
    FOREIGN KEY (`grapeVariety_id`)
    REFERENCES `wineManager`.`grapeVarieties` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `wineManager`.`wines_has_alerts`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `wineManager`.`wines_has_alerts` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `alert_id` INT NOT NULL,
  `wine_id` INT NULL,
  INDEX `fk_wines_has_alerts_alerts1_idx` (`alert_id` ASC),
  INDEX `fk_wines_has_alerts_wines1_idx` (`wine_id` ASC),
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  CONSTRAINT `fk_wines_has_alerts_wines1`
    FOREIGN KEY (`wine_id`)
    REFERENCES `wineManager`.`wines` (`id`)
    ON DELETE SET NULL
    ON UPDATE CASCADE,
  CONSTRAINT `fk_wines_has_alerts_alerts1`
    FOREIGN KEY (`alert_id`)
    REFERENCES `wineManager`.`alerts` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
