namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsImagebuilderInfrastructureConfigurationsState = { assignments: ResizeArray<aws.DataAwsImagebuilderInfrastructureConfigurations.DataAwsImagebuilderInfrastructureConfigurationsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_infrastructure_configurations">aws_imagebuilder_infrastructure_configurations</a>.
    /// </summary>
    type DataAwsImagebuilderInfrastructureConfigurationsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsImagebuilderInfrastructureConfigurationsState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsImagebuilderInfrastructureConfigurationsState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_infrastructure_configurations#filter-1">DataAwsImagebuilderInfrastructureConfigurations#filter</a> Accepts: aws.IResolvable | aws.DataAwsImagebuilderInfrastructureConfigurations.DataAwsImagebuilderInfrastructureConfigurationsFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsImagebuilderInfrastructureConfigurationsState, value: HashiCorp.Cdktf.IResolvable) : DataAwsImagebuilderInfrastructureConfigurationsState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsImagebuilderInfrastructureConfigurationsState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/imagebuilder_infrastructure_configurations#id-1">DataAwsImagebuilderInfrastructureConfigurations#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsImagebuilderInfrastructureConfigurationsState, value: string) : DataAwsImagebuilderInfrastructureConfigurationsState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsImagebuilderInfrastructureConfigurationsState

        member _.Run(state: DataAwsImagebuilderInfrastructureConfigurationsState) : aws.DataAwsImagebuilderInfrastructureConfigurations.DataAwsImagebuilderInfrastructureConfigurations =
            let config = aws.DataAwsImagebuilderInfrastructureConfigurations.DataAwsImagebuilderInfrastructureConfigurationsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsImagebuilderInfrastructureConfigurations.DataAwsImagebuilderInfrastructureConfigurations(StackContext.get (), logicalId, config)
