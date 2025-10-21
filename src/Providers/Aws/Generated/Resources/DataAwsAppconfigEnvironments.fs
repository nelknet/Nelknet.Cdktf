namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAppconfigEnvironmentsState<'ApplicationId> = { assignments: ResizeArray<aws.DataAwsAppconfigEnvironments.DataAwsAppconfigEnvironmentsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appconfig_environments">aws_appconfig_environments</a>.
    /// </summary>
    type DataAwsAppconfigEnvironmentsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAppconfigEnvironmentsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppconfigEnvironmentsState<Missing>)

        member _.Zero(()) : DataAwsAppconfigEnvironmentsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppconfigEnvironmentsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appconfig_environments#application_id-1">DataAwsAppconfigEnvironments#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: DataAwsAppconfigEnvironmentsState<Missing>, value: string) : DataAwsAppconfigEnvironmentsState<Present> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : DataAwsAppconfigEnvironmentsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appconfig_environments#id-1">DataAwsAppconfigEnvironments#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAppconfigEnvironmentsState<'ApplicationId>, value: string) : DataAwsAppconfigEnvironmentsState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAppconfigEnvironmentsState<'ApplicationId>

        member _.Run(state: DataAwsAppconfigEnvironmentsState<Present>) : aws.DataAwsAppconfigEnvironments.DataAwsAppconfigEnvironments =
            let config = aws.DataAwsAppconfigEnvironments.DataAwsAppconfigEnvironmentsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAppconfigEnvironments.DataAwsAppconfigEnvironments(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAppconfigEnvironments: missing required arguments. Must call: application_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAppconfigEnvironmentsState<_>) : aws.DataAwsAppconfigEnvironments.DataAwsAppconfigEnvironments =
            Unchecked.defaultof<aws.DataAwsAppconfigEnvironments.DataAwsAppconfigEnvironments>
