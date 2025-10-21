namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueSecurityConfigurationState<'EncryptionConfiguration, 'Name> = { assignments: ResizeArray<aws.GlueSecurityConfiguration.GlueSecurityConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_security_configuration">aws_glue_security_configuration</a>.
    /// </summary>
    type GlueSecurityConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueSecurityConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueSecurityConfigurationState<Missing, Missing>)

        member _.Zero(()) : GlueSecurityConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueSecurityConfigurationState<Missing, Missing>)

        /// <summary>
        /// encryption_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_security_configuration#encryption_configuration-1">GlueSecurityConfiguration#encryption_configuration</a>
        /// </summary>
        [<CustomOperation "encryption_configuration">]
        member _.EncryptionConfiguration(state: GlueSecurityConfigurationState<Missing, 'Name>, value: aws.GlueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfiguration) : GlueSecurityConfigurationState<Present, 'Name> =
            state.assignments.Add(fun config -> config.EncryptionConfiguration <- value)
            ({ assignments = state.assignments } : GlueSecurityConfigurationState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_security_configuration#name-1">GlueSecurityConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlueSecurityConfigurationState<'EncryptionConfiguration, Missing>, value: string) : GlueSecurityConfigurationState<'EncryptionConfiguration, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GlueSecurityConfigurationState<'EncryptionConfiguration, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_security_configuration#id-1">GlueSecurityConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueSecurityConfigurationState<'EncryptionConfiguration, 'Name>, value: string) : GlueSecurityConfigurationState<'EncryptionConfiguration, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueSecurityConfigurationState<'EncryptionConfiguration, 'Name>

        member _.Run(state: GlueSecurityConfigurationState<Present, Present>) : aws.GlueSecurityConfiguration.GlueSecurityConfiguration =
            let config = aws.GlueSecurityConfiguration.GlueSecurityConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.GlueSecurityConfiguration.GlueSecurityConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueSecurityConfiguration: missing required arguments. Must call: encryption_configuration, name.", 9999, IsError = true)>]
        member _.Run(_: GlueSecurityConfigurationState<_, _>) : aws.GlueSecurityConfiguration.GlueSecurityConfiguration =
            Unchecked.defaultof<aws.GlueSecurityConfiguration.GlueSecurityConfiguration>
