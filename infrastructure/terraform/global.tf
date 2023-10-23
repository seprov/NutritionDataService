module "global" {
  source = "./global"

  app_name             = var.app_name
  aws_region           = var.aws_region
  nutritiondataservice = module.region.nutritiondataservice
}