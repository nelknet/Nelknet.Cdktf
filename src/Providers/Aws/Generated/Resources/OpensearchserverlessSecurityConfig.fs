namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpensearchserverlessSecurityConfigState<'Name, 'Type> = { assignments: ResizeArray<aws.OpensearchserverlessSecurityConfig.OpensearchserverlessSecurityConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_security_config">aws_opensearchserverless_security_config</a>.
    /// </summary>
    type OpensearchserverlessSecurityConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpensearchserverlessSecurityConfigState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchserverlessSecurityConfigState<Missing, Missing>)

        member _.Zero(()) : OpensearchserverlessSecurityConfigState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchserverlessSecurityConfigState<Missing, Missing>)

        /// <summary>
        /// Name of the policy. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_security_config#name-1">OpensearchserverlessSecurityConfig#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OpensearchserverlessSecurityConfigState<Missing, 'Type>, value: string) : OpensearchserverlessSecurityConfigState<Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OpensearchserverlessSecurityConfigState<Present, 'Type>)

        /// <summary>
        /// Type of configuration. Must be `saml`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_security_config#type-1">OpensearchserverlessSecurityConfig#type</a>
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: OpensearchserverlessSecurityConfigState<'Name, Missing>, value: string) : OpensearchserverlessSecurityConfigState<'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : OpensearchserverlessSecurityConfigState<'Name, Present>)

        /// <summary>
        /// Description of the security configuration. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_security_config#description-1">OpensearchserverlessSecurityConfig#description</a>
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: OpensearchserverlessSecurityConfigState<'Name, 'Type>, value: string) : OpensearchserverlessSecurityConfigState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : OpensearchserverlessSecurityConfigState<'Name, 'Type>

        /// <summary>
        /// saml_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearchserverless_security_config#saml_options-1">OpensearchserverlessSecurityConfig#saml_options</a>
        /// </summary>
        [<CustomOperation "saml_options">]
        member _.SamlOptions(state: OpensearchserverlessSecurityConfigState<'Name, 'Type>, value: aws.OpensearchserverlessSecurityConfig.OpensearchserverlessSecurityConfigSamlOptions) : OpensearchserverlessSecurityConfigState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.SamlOptions <- value)
            state : OpensearchserverlessSecurityConfigState<'Name, 'Type>

        member _.Run(state: OpensearchserverlessSecurityConfigState<Present, Present>) : aws.OpensearchserverlessSecurityConfig.OpensearchserverlessSecurityConfig =
            let config = aws.OpensearchserverlessSecurityConfig.OpensearchserverlessSecurityConfigConfig()
            for setter in state.assignments do
                setter config
            aws.OpensearchserverlessSecurityConfig.OpensearchserverlessSecurityConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opensearchserverlessSecurityConfig: missing required arguments. Must call: name, type.", 9999, IsError = true)>]
        member _.Run(_: OpensearchserverlessSecurityConfigState<_, _>) : aws.OpensearchserverlessSecurityConfig.OpensearchserverlessSecurityConfig =
            Unchecked.defaultof<aws.OpensearchserverlessSecurityConfig.OpensearchserverlessSecurityConfig>
