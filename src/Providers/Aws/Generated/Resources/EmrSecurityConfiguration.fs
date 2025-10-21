namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EmrSecurityConfigurationState<'Configuration> = { assignments: ResizeArray<aws.EmrSecurityConfiguration.EmrSecurityConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_security_configuration">aws_emr_security_configuration</a>.
    /// </summary>
    type EmrSecurityConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : EmrSecurityConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : EmrSecurityConfigurationState<Missing>)

        member _.Zero(()) : EmrSecurityConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : EmrSecurityConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_security_configuration#configuration-1">EmrSecurityConfiguration#configuration</a>.
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: EmrSecurityConfigurationState<Missing>, value: string) : EmrSecurityConfigurationState<Present> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            ({ assignments = state.assignments } : EmrSecurityConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_security_configuration#id-1">EmrSecurityConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EmrSecurityConfigurationState<'Configuration>, value: string) : EmrSecurityConfigurationState<'Configuration> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EmrSecurityConfigurationState<'Configuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_security_configuration#name-1">EmrSecurityConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EmrSecurityConfigurationState<'Configuration>, value: string) : EmrSecurityConfigurationState<'Configuration> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : EmrSecurityConfigurationState<'Configuration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_security_configuration#name_prefix-1">EmrSecurityConfiguration#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: EmrSecurityConfigurationState<'Configuration>, value: string) : EmrSecurityConfigurationState<'Configuration> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : EmrSecurityConfigurationState<'Configuration>

        member _.Run(state: EmrSecurityConfigurationState<Present>) : aws.EmrSecurityConfiguration.EmrSecurityConfiguration =
            let config = aws.EmrSecurityConfiguration.EmrSecurityConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.EmrSecurityConfiguration.EmrSecurityConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.emrSecurityConfiguration: missing required arguments. Must call: configuration.", 9999, IsError = true)>]
        member _.Run(_: EmrSecurityConfigurationState<_>) : aws.EmrSecurityConfiguration.EmrSecurityConfiguration =
            Unchecked.defaultof<aws.EmrSecurityConfiguration.EmrSecurityConfiguration>
