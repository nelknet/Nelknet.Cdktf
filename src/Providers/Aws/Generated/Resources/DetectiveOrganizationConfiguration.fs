namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DetectiveOrganizationConfigurationState<'AutoEnable, 'GraphArn> = { assignments: ResizeArray<aws.DetectiveOrganizationConfiguration.DetectiveOrganizationConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_organization_configuration">aws_detective_organization_configuration</a>.
    /// </summary>
    type DetectiveOrganizationConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : DetectiveOrganizationConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DetectiveOrganizationConfigurationState<Missing, Missing>)

        member _.Zero(()) : DetectiveOrganizationConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DetectiveOrganizationConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_organization_configuration#auto_enable-1">DetectiveOrganizationConfiguration#auto_enable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_enable">]
        member _.AutoEnable(state: DetectiveOrganizationConfigurationState<Missing, 'GraphArn>, value: bool) : DetectiveOrganizationConfigurationState<Present, 'GraphArn> =
            state.assignments.Add(fun config -> config.AutoEnable <- value)
            ({ assignments = state.assignments } : DetectiveOrganizationConfigurationState<Present, 'GraphArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_organization_configuration#auto_enable-1">DetectiveOrganizationConfiguration#auto_enable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "auto_enable">]
        member _.AutoEnable(state: DetectiveOrganizationConfigurationState<Missing, 'GraphArn>, value: HashiCorp.Cdktf.IResolvable) : DetectiveOrganizationConfigurationState<Present, 'GraphArn> =
            state.assignments.Add(fun config -> config.AutoEnable <- value)
            ({ assignments = state.assignments } : DetectiveOrganizationConfigurationState<Present, 'GraphArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_organization_configuration#graph_arn-1">DetectiveOrganizationConfiguration#graph_arn</a>.
        /// </summary>
        [<CustomOperation "graph_arn">]
        member _.GraphArn(state: DetectiveOrganizationConfigurationState<'AutoEnable, Missing>, value: string) : DetectiveOrganizationConfigurationState<'AutoEnable, Present> =
            state.assignments.Add(fun config -> config.GraphArn <- value)
            ({ assignments = state.assignments } : DetectiveOrganizationConfigurationState<'AutoEnable, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_organization_configuration#id-1">DetectiveOrganizationConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DetectiveOrganizationConfigurationState<'AutoEnable, 'GraphArn>, value: string) : DetectiveOrganizationConfigurationState<'AutoEnable, 'GraphArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DetectiveOrganizationConfigurationState<'AutoEnable, 'GraphArn>

        member _.Run(state: DetectiveOrganizationConfigurationState<Present, Present>) : aws.DetectiveOrganizationConfiguration.DetectiveOrganizationConfiguration =
            let config = aws.DetectiveOrganizationConfiguration.DetectiveOrganizationConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.DetectiveOrganizationConfiguration.DetectiveOrganizationConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.detectiveOrganizationConfiguration: missing required arguments. Must call: auto_enable, graph_arn.", 9999, IsError = true)>]
        member _.Run(_: DetectiveOrganizationConfigurationState<_, _>) : aws.DetectiveOrganizationConfiguration.DetectiveOrganizationConfiguration =
            Unchecked.defaultof<aws.DetectiveOrganizationConfiguration.DetectiveOrganizationConfiguration>
