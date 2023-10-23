module "region" {
  source = "./region"

  app_name             = var.app_name
  aws_region           = var.aws_region
  ecs_task_iam_role    = module.global.ecs_task_iam_role
}