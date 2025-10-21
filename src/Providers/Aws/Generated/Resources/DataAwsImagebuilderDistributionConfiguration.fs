namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsImagebuilderDistributionConfigurationState<'Arn> = { assignments: ResizeArray<aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_distribution_configuration">aws_imagebuilder_distribution_configuration</a>.
    /// </summary>
    type DataAwsImagebuilderDistributionConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsImagebuilderDistributionConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsImagebuilderDistributionConfigurationState<Missing>)

        member _.Zero(()) : DataAwsImagebuilderDistributionConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsImagebuilderDistributionConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_distribution_configuration#arn-1">DataAwsImagebuilderDistributionConfiguration#arn</a>.
        /// </summary>
        [<CustomOperation "arn">]
        member _.Arn(state: DataAwsImagebuilderDistributionConfigurationState<Missing>, value: string) : DataAwsImagebuilderDistributionConfigurationState<Present> =
            state.assignments.Add(fun config -> config.Arn <- value)
            ({ assignments = state.assignments } : DataAwsImagebuilderDistributionConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_distribution_configuration#id-1">DataAwsImagebuilderDistributionConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsImagebuilderDistributionConfigurationState<'Arn>, value: string) : DataAwsImagebuilderDistributionConfigurationState<'Arn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsImagebuilderDistributionConfigurationState<'Arn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_distribution_configuration#tags-1">DataAwsImagebuilderDistributionConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsImagebuilderDistributionConfigurationState<'Arn>, value: seq<string * string>) : DataAwsImagebuilderDistributionConfigurationState<'Arn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsImagebuilderDistributionConfigurationState<'Arn>

        member _.Run(state: DataAwsImagebuilderDistributionConfigurationState<Present>) : aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfiguration =
            let config = aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsImagebuilderDistributionConfiguration: missing required arguments. Must call: arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsImagebuilderDistributionConfigurationState<_>) : aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfiguration =
            Unchecked.defaultof<aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfiguration>
