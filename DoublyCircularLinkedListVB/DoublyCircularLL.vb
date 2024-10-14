Namespace DoublyCircularLinkedList
    Friend Class DoublyCircularLL
        Public head As Node

        Public Sub New()
            head = Nothing
        End Sub

        Public Sub Add(newNode As Node)
            ' Si la lista está vacía 
            If head Is Nothing Then
                head = newNode
                head.Nextt = head
                head.Prev = head
                Return
            End If

            ' Agregar un nodo si ya hay nodos en la lista 
            ' Insertar un nodo al inicio 
            If newNode.Value < head.Value Then
                newNode.Nextt = head
                newNode.Prev = head.Prev
                head.Prev.Nextt = newNode ' Se actualiza el next del último nodo para que apunte al nuevo nodo
                head.Prev = newNode
                head = newNode
                Return
            End If

            ' Insertar un nodo al final 
            ' Evalúa si el valor del nuevo nodo es mayor al valor del último nodo (head.Prev.Value)
            If newNode.Value > head.Prev.Value Then
                newNode.Nextt = head ' El siguiente de newNode
                newNode.Prev = head.Prev
                head.Prev.Nextt = newNode ' Actualiza el siguiente del último nodo
                head.Prev = newNode ' Actualiza el anterior de head al nuevo nodo
                Return
            End If

            ' Encontrar la posición correcta para el nuevo nodo
            Dim current As Node = head

            ' Recorrer la lista para encontrar el lugar correcto
            While current.Nextt IsNot head AndAlso current.Nextt.Value < newNode.Value
                current = current.Nextt
            End While

            ' Insertar el nuevo nodo
            newNode.Nextt = current.Nextt
            newNode.Prev = current

            current.Nextt.Prev = newNode ' Actualizar el anterior del siguiente nodo
            current.Nextt = newNode ' Enlazar el nodo actual al nuevo nodo
        End Sub

        Public Sub Remove(value As Integer)
            If head Is Nothing Then
                Return
            End If

            If head.Nextt Is head Then ' Solo hay un nodo en la lista
                head = Nothing ' La lista queda vacía
                Return
            End If

            ' Eliminación al inicio 
            If head.Value = value Then
                head.Prev.Nextt = head.Nextt ' Actualizar el siguiente del último nodo
                head.Nextt.Prev = head.Prev ' Actualizar el anterior del segundo nodo
                head = head.Nextt ' Actualizar head al siguiente nodo
                Return
            End If

            ' Eliminación al final 
            If head.Prev.Value = value Then
                ' Aquí eliminamos el último nodo
                head.Prev = head.Prev.Prev ' Mover el puntero de cabeza hacia atrás
                head.Prev.Nextt = head ' Actualizar el siguiente del nuevo último nodo
                Return
            End If

            ' Eliminación de un nodo intermedio
            Dim current As Node = head
            While current.Nextt IsNot head AndAlso current.Value <> value
                current = current.Nextt
            End While

            ' Si el nodo con el valor fue encontrado
            If current.Value = value Then
                current.Prev.Nextt = current.Nextt ' Actualizar el siguiente del nodo anterior
                current.Nextt.Prev = current.Prev ' Actualizar el anterior del nodo siguiente
            End If
        End Sub

        Public Function Contains(value As Integer) As Boolean
            If head Is Nothing Then
                Return False
            End If

            Dim current As Node = head
            Do
                If current.Value = value Then
                    Return True
                End If
                current = current.Nextt
            Loop While current IsNot head
            Return False
        End Function

        Public Overrides Function ToString() As String
            If head Is Nothing Then
                Return "The doubly circular linked list is void"
            End If

            Dim result As String = ""
            Dim current As Node = head

            Do
                result += current.ToString() & " " ' Llama al ToString del nodo
                current = current.Nextt ' Avanza al siguiente nodo
            Loop While current IsNot head ' Detenerse cuando se regrese al nodo cabeza

            Return result
        End Function
    End Class
End Namespace