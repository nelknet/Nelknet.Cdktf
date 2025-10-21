namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsServerlessapplicationrepositoryApplicationState<'ApplicationId> = { assignments: ResizeArray<aws.DataAwsServerlessapplicationrepositoryApplication.DataAwsServerlessapplicationrepositoryApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/serverlessapplicationrepository_application">aws_serverlessapplicationrepository_application</a>.
    /// </summary>
    type DataAwsServerlessapplicationrepositoryApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsServerlessapplicationrepositoryApplicationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServerlessapplicationrepositoryApplicationState<Missing>)

        member _.Zero(()) : DataAwsServerlessapplicationrepositoryApplicationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsServerlessapplicationrepositoryApplicationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/serverlessapplicationrepository_application#application_id-1">DataAwsServerlessapplicationrepositoryApplication#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: DataAwsServerlessapplicationrepositoryApplicationState<Missing>, value: string) : DataAwsServerlessapplicationrepositoryApplicationState<Present> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : DataAwsServerlessapplicationrepositoryApplicationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/serverlessapplicationrepository_application#id-1">DataAwsServerlessapplicationrepositoryApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsServerlessapplicationrepositoryApplicationState<'ApplicationId>, value: string) : DataAwsServerlessapplicationrepositoryApplicationState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsServerlessapplicationrepositoryApplicationState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/serverlessapplicationrepository_application#semantic_version-1">DataAwsServerlessapplicationrepositoryApplication#semantic_version</a>.
        /// </summary>
        [<CustomOperation "semantic_version">]
        member _.SemanticVersion(state: DataAwsServerlessapplicationrepositoryApplicationState<'ApplicationId>, value: string) : DataAwsServerlessapplicationrepositoryApplicationState<'ApplicationId> =
            state.assignments.Add(fun config -> config.SemanticVersion <- value)
            state : DataAwsServerlessapplicationrepositoryApplicationState<'ApplicationId>

        member _.Run(state: DataAwsServerlessapplicationrepositoryApplicationState<Present>) : aws.DataAwsServerlessapplicationrepositoryApplication.DataAwsServerlessapplicationrepositoryApplication =
            let config = aws.DataAwsServerlessapplicationrepositoryApplication.DataAwsServerlessapplicationrepositoryApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsServerlessapplicationrepositoryApplication.DataAwsServerlessapplicationrepositoryApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsServerlessapplicationrepositoryApplication: missing required arguments. Must call: application_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsServerlessapplicationrepositoryApplicationState<_>) : aws.DataAwsServerlessapplicationrepositoryApplication.DataAwsServerlessapplicationrepositoryApplication =
            Unchecked.defaultof<aws.DataAwsServerlessapplicationrepositoryApplication.DataAwsServerlessapplicationrepositoryApplication>
