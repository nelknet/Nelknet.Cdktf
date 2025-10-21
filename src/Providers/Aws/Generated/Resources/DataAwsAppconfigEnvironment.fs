namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAppconfigEnvironmentState<'ApplicationId, 'EnvironmentId> = { assignments: ResizeArray<aws.DataAwsAppconfigEnvironment.DataAwsAppconfigEnvironmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appconfig_environment">aws_appconfig_environment</a>.
    /// </summary>
    type DataAwsAppconfigEnvironmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAppconfigEnvironmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppconfigEnvironmentState<Missing, Missing>)

        member _.Zero(()) : DataAwsAppconfigEnvironmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsAppconfigEnvironmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appconfig_environment#application_id-1">DataAwsAppconfigEnvironment#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: DataAwsAppconfigEnvironmentState<Missing, 'EnvironmentId>, value: string) : DataAwsAppconfigEnvironmentState<Present, 'EnvironmentId> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : DataAwsAppconfigEnvironmentState<Present, 'EnvironmentId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appconfig_environment#environment_id-1">DataAwsAppconfigEnvironment#environment_id</a>.
        /// </summary>
        [<CustomOperation "environment_id">]
        member _.EnvironmentId(state: DataAwsAppconfigEnvironmentState<'ApplicationId, Missing>, value: string) : DataAwsAppconfigEnvironmentState<'ApplicationId, Present> =
            state.assignments.Add(fun config -> config.EnvironmentId <- value)
            ({ assignments = state.assignments } : DataAwsAppconfigEnvironmentState<'ApplicationId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appconfig_environment#id-1">DataAwsAppconfigEnvironment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAppconfigEnvironmentState<'ApplicationId, 'EnvironmentId>, value: string) : DataAwsAppconfigEnvironmentState<'ApplicationId, 'EnvironmentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAppconfigEnvironmentState<'ApplicationId, 'EnvironmentId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/appconfig_environment#tags-1">DataAwsAppconfigEnvironment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsAppconfigEnvironmentState<'ApplicationId, 'EnvironmentId>, value: seq<string * string>) : DataAwsAppconfigEnvironmentState<'ApplicationId, 'EnvironmentId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsAppconfigEnvironmentState<'ApplicationId, 'EnvironmentId>

        member _.Run(state: DataAwsAppconfigEnvironmentState<Present, Present>) : aws.DataAwsAppconfigEnvironment.DataAwsAppconfigEnvironment =
            let config = aws.DataAwsAppconfigEnvironment.DataAwsAppconfigEnvironmentConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAppconfigEnvironment.DataAwsAppconfigEnvironment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsAppconfigEnvironment: missing required arguments. Must call: application_id, environment_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsAppconfigEnvironmentState<_, _>) : aws.DataAwsAppconfigEnvironment.DataAwsAppconfigEnvironment =
            Unchecked.defaultof<aws.DataAwsAppconfigEnvironment.DataAwsAppconfigEnvironment>
