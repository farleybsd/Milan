﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations;

/// <inheritdoc />
public partial class Inicial : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.EnsureSchema(
            name: "public");

        migrationBuilder.CreateTable(
            name: "todo_items",
            schema: "public",
            columns: table => new
            {
                id = table.Column<Guid>(type: "uuid", nullable: false),
                user_id = table.Column<Guid>(type: "uuid", nullable: false),
                description = table.Column<string>(type: "text", nullable: false),
                due_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                labels = table.Column<List<string>>(type: "text[]", nullable: false),
                is_completed = table.Column<bool>(type: "boolean", nullable: false),
                created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                completed_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                priority = table.Column<int>(type: "integer", nullable: false)
            },
            constraints: table => table.PrimaryKey("pk_todo_items", x => x.id));

        migrationBuilder.CreateTable(
            name: "users",
            schema: "public",
            columns: table => new
            {
                id = table.Column<Guid>(type: "uuid", nullable: false),
                email = table.Column<string>(type: "text", nullable: false),
                first_name = table.Column<string>(type: "text", nullable: false),
                last_name = table.Column<string>(type: "text", nullable: false),
                password_hash = table.Column<string>(type: "text", nullable: false)
            },
            constraints: table => table.PrimaryKey("pk_users", x => x.id));
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "todo_items",
            schema: "public");

        migrationBuilder.DropTable(
            name: "users",
            schema: "public");
    }
}
