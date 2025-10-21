namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOpensearchserverlessSecurityConfigState<'Id> = { assignments: ResizeArray<aws.DataAwsOpensearchserverlessSecurityConfig.DataAwsOpensearchserverlessSecurityConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearchserverless_security_config">aws_opensearchserverless_security_config</a>.
    /// </summary>
    type DataAwsOpensearchserverlessSecurityConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOpensearchserverlessSecurityConfigState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOpensearchserverlessSecurityConfigState<Missing>)

        member _.Zero(()) : DataAwsOpensearchserverlessSecurityConfigState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOpensearchserverlessSecurityConfigState<Missing>)

        /// <summary>
        /// The unique identifier of the security configuration. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/opensearchserverless_security_config#id-1">DataAwsOpensearchserverlessSecurityConfig#id</a> Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOpensearchserverlessSecurityConfigState<Missing>, value: string) : DataAwsOpensearchserverlessSecurityConfigState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsOpensearchserverlessSecurityConfigState<Present>)

        member _.Run(state: DataAwsOpensearchserverlessSecurityConfigState<Present>) : aws.DataAwsOpensearchserverlessSecurityConfig.DataAwsOpensearchserverlessSecurityConfig =
            let config = aws.DataAwsOpensearchserverlessSecurityConfig.DataAwsOpensearchserverlessSecurityConfigConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOpensearchserverlessSecurityConfig.DataAwsOpensearchserverlessSecurityConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOpensearchserverlessSecurityConfig: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOpensearchserverlessSecurityConfigState<_>) : aws.DataAwsOpensearchserverlessSecurityConfig.DataAwsOpensearchserverlessSecurityConfig =
            Unchecked.defaultof<aws.DataAwsOpensearchserverlessSecurityConfig.DataAwsOpensearchserverlessSecurityConfig>
