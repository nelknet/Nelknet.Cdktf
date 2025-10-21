namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, 'Name, 'Password, 'SpringCloudAppId, 'Username> = { assignments: ResizeArray<azurerm.SpringCloudAppMysqlAssociation.SpringCloudAppMysqlAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_mysql_association">azurerm_spring_cloud_app_mysql_association</a>.
    /// </summary>
    type SpringCloudAppMysqlAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudAppMysqlAssociationState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudAppMysqlAssociationState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudAppMysqlAssociationState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudAppMysqlAssociationState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_mysql_association#database_name-1">SpringCloudAppMysqlAssociation#database_name</a>.
        /// </summary>
        [<CustomOperation "database_name">]
        member _.DatabaseName(state: SpringCloudAppMysqlAssociationState<Missing, 'MysqlServerId, 'Name, 'Password, 'SpringCloudAppId, 'Username>, value: string) : SpringCloudAppMysqlAssociationState<Present, 'MysqlServerId, 'Name, 'Password, 'SpringCloudAppId, 'Username> =
            state.assignments.Add(fun config -> config.DatabaseName <- value)
            ({ assignments = state.assignments } : SpringCloudAppMysqlAssociationState<Present, 'MysqlServerId, 'Name, 'Password, 'SpringCloudAppId, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_mysql_association#mysql_server_id-1">SpringCloudAppMysqlAssociation#mysql_server_id</a>.
        /// </summary>
        [<CustomOperation "mysql_server_id">]
        member _.MysqlServerId(state: SpringCloudAppMysqlAssociationState<'DatabaseName, Missing, 'Name, 'Password, 'SpringCloudAppId, 'Username>, value: string) : SpringCloudAppMysqlAssociationState<'DatabaseName, Present, 'Name, 'Password, 'SpringCloudAppId, 'Username> =
            state.assignments.Add(fun config -> config.MysqlServerId <- value)
            ({ assignments = state.assignments } : SpringCloudAppMysqlAssociationState<'DatabaseName, Present, 'Name, 'Password, 'SpringCloudAppId, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_mysql_association#name-1">SpringCloudAppMysqlAssociation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, Missing, 'Password, 'SpringCloudAppId, 'Username>, value: string) : SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, Present, 'Password, 'SpringCloudAppId, 'Username> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, Present, 'Password, 'SpringCloudAppId, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_mysql_association#password-1">SpringCloudAppMysqlAssociation#password</a>.
        /// </summary>
        [<CustomOperation "password">]
        member _.Password(state: SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, 'Name, Missing, 'SpringCloudAppId, 'Username>, value: string) : SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, 'Name, Present, 'SpringCloudAppId, 'Username> =
            state.assignments.Add(fun config -> config.Password <- value)
            ({ assignments = state.assignments } : SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, 'Name, Present, 'SpringCloudAppId, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_mysql_association#spring_cloud_app_id-1">SpringCloudAppMysqlAssociation#spring_cloud_app_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_app_id">]
        member _.SpringCloudAppId(state: SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, 'Name, 'Password, Missing, 'Username>, value: string) : SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, 'Name, 'Password, Present, 'Username> =
            state.assignments.Add(fun config -> config.SpringCloudAppId <- value)
            ({ assignments = state.assignments } : SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, 'Name, 'Password, Present, 'Username>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_mysql_association#username-1">SpringCloudAppMysqlAssociation#username</a>.
        /// </summary>
        [<CustomOperation "username">]
        member _.Username(state: SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, 'Name, 'Password, 'SpringCloudAppId, Missing>, value: string) : SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, 'Name, 'Password, 'SpringCloudAppId, Present> =
            state.assignments.Add(fun config -> config.Username <- value)
            ({ assignments = state.assignments } : SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, 'Name, 'Password, 'SpringCloudAppId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_mysql_association#id-1">SpringCloudAppMysqlAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, 'Name, 'Password, 'SpringCloudAppId, 'Username>, value: string) : SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, 'Name, 'Password, 'SpringCloudAppId, 'Username> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, 'Name, 'Password, 'SpringCloudAppId, 'Username>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app_mysql_association#timeouts-1">SpringCloudAppMysqlAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, 'Name, 'Password, 'SpringCloudAppId, 'Username>, value: azurerm.SpringCloudAppMysqlAssociation.SpringCloudAppMysqlAssociationTimeouts) : SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, 'Name, 'Password, 'SpringCloudAppId, 'Username> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudAppMysqlAssociationState<'DatabaseName, 'MysqlServerId, 'Name, 'Password, 'SpringCloudAppId, 'Username>

        member _.Run(state: SpringCloudAppMysqlAssociationState<Present, Present, Present, Present, Present, Present>) : azurerm.SpringCloudAppMysqlAssociation.SpringCloudAppMysqlAssociation =
            let config = azurerm.SpringCloudAppMysqlAssociation.SpringCloudAppMysqlAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudAppMysqlAssociation.SpringCloudAppMysqlAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudAppMysqlAssociation: missing required arguments. Must call: database_name, mysql_server_id, name, password, spring_cloud_app_id, username.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudAppMysqlAssociationState<_, _, _, _, _, _>) : azurerm.SpringCloudAppMysqlAssociation.SpringCloudAppMysqlAssociation =
            Unchecked.defaultof<azurerm.SpringCloudAppMysqlAssociation.SpringCloudAppMysqlAssociation>
