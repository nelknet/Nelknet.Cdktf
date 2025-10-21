namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsImagebuilderDistributionConfigurationsState = { assignments: ResizeArray<aws.DataAwsImagebuilderDistributionConfigurations.DataAwsImagebuilderDistributionConfigurationsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_distribution_configurations">aws_imagebuilder_distribution_configurations</a>.
    /// </summary>
    type DataAwsImagebuilderDistributionConfigurationsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsImagebuilderDistributionConfigurationsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsImagebuilderDistributionConfigurationsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_distribution_configurations#filter-1">DataAwsImagebuilderDistributionConfigurations#filter</a> Accepts: aws.IResolvable | aws.DataAwsImagebuilderDistributionConfigurations.DataAwsImagebuilderDistributionConfigurationsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsImagebuilderDistributionConfigurationsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsImagebuilderDistributionConfigurationsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsImagebuilderDistributionConfigurationsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_distribution_configurations#id-1">DataAwsImagebuilderDistributionConfigurations#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsImagebuilderDistributionConfigurationsState, value: string) : DataAwsImagebuilderDistributionConfigurationsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsImagebuilderDistributionConfigurationsState

        member _.Run(state: DataAwsImagebuilderDistributionConfigurationsState) : aws.DataAwsImagebuilderDistributionConfigurations.DataAwsImagebuilderDistributionConfigurations =
            let config = aws.DataAwsImagebuilderDistributionConfigurations.DataAwsImagebuilderDistributionConfigurationsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsImagebuilderDistributionConfigurations.DataAwsImagebuilderDistributionConfigurations(StackContext.get (), logicalId, config)
