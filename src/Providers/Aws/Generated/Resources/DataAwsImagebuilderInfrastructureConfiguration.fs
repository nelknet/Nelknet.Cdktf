namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsImagebuilderInfrastructureConfigurationState<'Arn> = { assignments: ResizeArray<aws.DataAwsImagebuilderInfrastructureConfiguration.DataAwsImagebuilderInfrastructureConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_infrastructure_configuration">aws_imagebuilder_infrastructure_configuration</a>.
    /// </summary>
    type DataAwsImagebuilderInfrastructureConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsImagebuilderInfrastructureConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsImagebuilderInfrastructureConfigurationState<Missing>)

        member _.Zero(()) : DataAwsImagebuilderInfrastructureConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsImagebuilderInfrastructureConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_infrastructure_configuration#arn-1">DataAwsImagebuilderInfrastructureConfiguration#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsImagebuilderInfrastructureConfigurationState<Missing>, value: string) : DataAwsImagebuilderInfrastructureConfigurationState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsImagebuilderInfrastructureConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_infrastructure_configuration#id-1">DataAwsImagebuilderInfrastructureConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsImagebuilderInfrastructureConfigurationState<'Arn>, value: string) : DataAwsImagebuilderInfrastructureConfigurationState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsImagebuilderInfrastructureConfigurationState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_infrastructure_configuration#resource_tags-1">DataAwsImagebuilderInfrastructureConfiguration#resource_tags</a>.
        /// </summary>
        [<CustomOperation "resource_tags">]
        member _.ResourceTags(state: DataAwsImagebuilderInfrastructureConfigurationState<'Arn>, value: seq<string * string>) : DataAwsImagebuilderInfrastructureConfigurationState<'Arn> =
            state.assignments.Add(fun config -> config.ResourceTags <- dict value)
            state : DataAwsImagebuilderInfrastructureConfigurationState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_infrastructure_configuration#tags-1">DataAwsImagebuilderInfrastructureConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsImagebuilderInfrastructureConfigurationState<'Arn>, value: seq<string * string>) : DataAwsImagebuilderInfrastructureConfigurationState<'Arn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsImagebuilderInfrastructureConfigurationState<'Arn>

        member _.Run(state: DataAwsImagebuilderInfrastructureConfigurationState<Present>) : aws.DataAwsImagebuilderInfrastructureConfiguration.DataAwsImagebuilderInfrastructureConfiguration =
            let config = aws.DataAwsImagebuilderInfrastructureConfiguration.DataAwsImagebuilderInfrastructureConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsImagebuilderInfrastructureConfiguration.DataAwsImagebuilderInfrastructureConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsImagebuilderInfrastructureConfiguration: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsImagebuilderInfrastructureConfigurationState<_>) : aws.DataAwsImagebuilderInfrastructureConfiguration.DataAwsImagebuilderInfrastructureConfiguration =
            Unchecked.defaultof<aws.DataAwsImagebuilderInfrastructureConfiguration.DataAwsImagebuilderInfrastructureConfiguration>
