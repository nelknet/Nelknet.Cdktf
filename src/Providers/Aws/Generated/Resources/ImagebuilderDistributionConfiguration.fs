namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ImagebuilderDistributionConfigurationState<'Distribution, 'Name> = { assignments: ResizeArray<aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration">aws_imagebuilder_distribution_configuration</a>.
    /// </summary>
    type ImagebuilderDistributionConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ImagebuilderDistributionConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderDistributionConfigurationState<Missing, Missing>)

        member _.Zero(()) : ImagebuilderDistributionConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ImagebuilderDistributionConfigurationState<Missing, Missing>)

        /// <summary>
        /// distribution block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#distribution-1">ImagebuilderDistributionConfiguration#distribution</a> Accepts: aws.IResolvable | aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationDistribution[]
        /// </summary>
        [<CustomOperation "distribution">]
        member _.Distribution(state: ImagebuilderDistributionConfigurationState<Missing, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ImagebuilderDistributionConfigurationState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Distribution <- value)
            ({ assignments = state.assignments } : ImagebuilderDistributionConfigurationState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#name-1">ImagebuilderDistributionConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ImagebuilderDistributionConfigurationState<'Distribution, Missing>, value: string) : ImagebuilderDistributionConfigurationState<'Distribution, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ImagebuilderDistributionConfigurationState<'Distribution, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#description-1">ImagebuilderDistributionConfiguration#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ImagebuilderDistributionConfigurationState<'Distribution, 'Name>, value: string) : ImagebuilderDistributionConfigurationState<'Distribution, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ImagebuilderDistributionConfigurationState<'Distribution, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#id-1">ImagebuilderDistributionConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ImagebuilderDistributionConfigurationState<'Distribution, 'Name>, value: string) : ImagebuilderDistributionConfigurationState<'Distribution, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ImagebuilderDistributionConfigurationState<'Distribution, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#tags-1">ImagebuilderDistributionConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ImagebuilderDistributionConfigurationState<'Distribution, 'Name>, value: seq<string * string>) : ImagebuilderDistributionConfigurationState<'Distribution, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ImagebuilderDistributionConfigurationState<'Distribution, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_distribution_configuration#tags_all-1">ImagebuilderDistributionConfiguration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ImagebuilderDistributionConfigurationState<'Distribution, 'Name>, value: seq<string * string>) : ImagebuilderDistributionConfigurationState<'Distribution, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ImagebuilderDistributionConfigurationState<'Distribution, 'Name>

        member _.Run(state: ImagebuilderDistributionConfigurationState<Present, Present>) : aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfiguration =
            let config = aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.imagebuilderDistributionConfiguration: missing required arguments. Must call: distribution, name.", 9999, IsError = true)>]
        member _.Run(_: ImagebuilderDistributionConfigurationState<_, _>) : aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfiguration =
            Unchecked.defaultof<aws.ImagebuilderDistributionConfiguration.ImagebuilderDistributionConfiguration>
