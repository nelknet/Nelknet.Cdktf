namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEcrRepositoriesState = { assignments: ResizeArray<aws.DataAwsEcrRepositories.DataAwsEcrRepositoriesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecr_repositories">aws_ecr_repositories</a>.
    /// </summary>
    type DataAwsEcrRepositoriesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEcrRepositoriesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsEcrRepositoriesState =
            { assignments = ResizeArray() }



        member _.Run(state: DataAwsEcrRepositoriesState) : aws.DataAwsEcrRepositories.DataAwsEcrRepositories =
            let config = aws.DataAwsEcrRepositories.DataAwsEcrRepositoriesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEcrRepositories.DataAwsEcrRepositories(StackContext.get (), logicalId, config)
