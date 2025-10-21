namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudformationTypeState<'SchemaHandlerPackage, 'TypeName> = { assignments: ResizeArray<aws.CloudformationType.CloudformationTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_type">aws_cloudformation_type</a>.
    /// </summary>
    type CloudformationTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudformationTypeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudformationTypeState<Missing, Missing>)

        member _.Zero(()) : CloudformationTypeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudformationTypeState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_type#schema_handler_package-1">CloudformationType#schema_handler_package</a>.
        /// </summary>
        [<CustomOperation "schema_handler_package">]
        member _.SchemaHandlerPackage(state: CloudformationTypeState<Missing, 'TypeName>, value: string) : CloudformationTypeState<Present, 'TypeName> =
            state.assignments.Add(fun config -> config.SchemaHandlerPackage <- value)
            ({ assignments = state.assignments } : CloudformationTypeState<Present, 'TypeName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_type#type_name-1">CloudformationType#type_name</a>.
        /// </summary>
        [<CustomOperation "type_name">]
        member _.TypeName(state: CloudformationTypeState<'SchemaHandlerPackage, Missing>, value: string) : CloudformationTypeState<'SchemaHandlerPackage, Present> =
            state.assignments.Add(fun config -> config.TypeName <- value)
            ({ assignments = state.assignments } : CloudformationTypeState<'SchemaHandlerPackage, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_type#execution_role_arn-1">CloudformationType#execution_role_arn</a>.
        /// </summary>
        [<CustomOperation "execution_role_arn">]
        member _.ExecutionRoleArn(state: CloudformationTypeState<'SchemaHandlerPackage, 'TypeName>, value: string) : CloudformationTypeState<'SchemaHandlerPackage, 'TypeName> =
            state.assignments.Add(fun config -> config.ExecutionRoleArn <- value)
            state : CloudformationTypeState<'SchemaHandlerPackage, 'TypeName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_type#id-1">CloudformationType#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudformationTypeState<'SchemaHandlerPackage, 'TypeName>, value: string) : CloudformationTypeState<'SchemaHandlerPackage, 'TypeName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudformationTypeState<'SchemaHandlerPackage, 'TypeName>

        /// <summary>
        /// logging_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_type#logging_config-1">CloudformationType#logging_config</a>
        /// </summary>
        [<CustomOperation "logging_config">]
        member _.LoggingConfig(state: CloudformationTypeState<'SchemaHandlerPackage, 'TypeName>, value: aws.CloudformationType.CloudformationTypeLoggingConfig) : CloudformationTypeState<'SchemaHandlerPackage, 'TypeName> =
            state.assignments.Add(fun config -> config.LoggingConfig <- value)
            state : CloudformationTypeState<'SchemaHandlerPackage, 'TypeName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudformation_type#type-1">CloudformationType#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: CloudformationTypeState<'SchemaHandlerPackage, 'TypeName>, value: string) : CloudformationTypeState<'SchemaHandlerPackage, 'TypeName> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : CloudformationTypeState<'SchemaHandlerPackage, 'TypeName>

        member _.Run(state: CloudformationTypeState<Present, Present>) : aws.CloudformationType.CloudformationType =
            let config = aws.CloudformationType.CloudformationTypeConfig()
            for setter in state.assignments do
                setter config
            aws.CloudformationType.CloudformationType(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudformationType: missing required arguments. Must call: schema_handler_package, type_name.", 9999, IsError = true)>]
        member _.Run(_: CloudformationTypeState<_, _>) : aws.CloudformationType.CloudformationType =
            Unchecked.defaultof<aws.CloudformationType.CloudformationType>
