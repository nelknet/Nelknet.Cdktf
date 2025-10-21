namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLaunchConfigurationState<'Name> = { assignments: ResizeArray<aws.DataAwsLaunchConfiguration.DataAwsLaunchConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/launch_configuration">aws_launch_configuration</a>.
    /// </summary>
    type DataAwsLaunchConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLaunchConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLaunchConfigurationState<Missing>)

        member _.Zero(()) : DataAwsLaunchConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLaunchConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/launch_configuration#name-1">DataAwsLaunchConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsLaunchConfigurationState<Missing>, value: string) : DataAwsLaunchConfigurationState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsLaunchConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/launch_configuration#id-1">DataAwsLaunchConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLaunchConfigurationState<'Name>, value: string) : DataAwsLaunchConfigurationState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLaunchConfigurationState<'Name>

        member _.Run(state: DataAwsLaunchConfigurationState<Present>) : aws.DataAwsLaunchConfiguration.DataAwsLaunchConfiguration =
            let config = aws.DataAwsLaunchConfiguration.DataAwsLaunchConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLaunchConfiguration.DataAwsLaunchConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLaunchConfiguration: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLaunchConfigurationState<_>) : aws.DataAwsLaunchConfiguration.DataAwsLaunchConfiguration =
            Unchecked.defaultof<aws.DataAwsLaunchConfiguration.DataAwsLaunchConfiguration>
